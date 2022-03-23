using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
     public GameObject target;
    public static bool spawn;
    public float xmax, xmin, ymax, ymin;
    private Vector3 posSpawn;


    // Start is called before the first frame update
    void Start()
    {
        spawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        posSpawn = new Vector3(Random.Range(xmax, xmin), Random.Range(ymax, ymin),0);
        if (spawn == true)
        {
            Instantiate(target, posSpawn, transform.rotation);
            spawn = false;
        }
    }
}
