using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color =Color.green;

        Gizmos.DrawWireCube(transform.position,Vector3.one*5);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position,transform.right * 3);
    }

}
