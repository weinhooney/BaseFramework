using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DataManagerBase
{
    private Dictionary<int, IDataTable> _dataTables = new Dictionary<int, IDataTable>();
    
    public virtual void Init()
    {
        
    }

    protected void AddDataTable(int key, IDataTable dataTable)
    {
        _dataTables.Add(key, dataTable);
    }
    
    protected T GetDataTable<T>(int key) where T : class, IDataTable
    {
        if (_dataTables.TryGetValue(key, out IDataTable dataTable) == false)
        {
            // 에러 처리
        }

        return dataTable as T;
    }
}
