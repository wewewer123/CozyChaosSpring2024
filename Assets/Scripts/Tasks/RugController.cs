using System.Collections;
using System.Collections.Generic;
// using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CozyChaosSpring2024
{
    public class RugController : MonoBehaviour
    {
        public GameObject smallRug;
        public GameObject largeRug;

        public GameObject rugTask;

        public TodoListScriptable todoList;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            Quaternion smallRotation = smallRug.GetComponent<Transform>().rotation;
            Quaternion largeRotation = largeRug.GetComponent<Transform>().rotation;
            if (smallRotation == Quaternion.Euler(-90, 0,0) && largeRotation == Quaternion.Euler(-90, 0,-11)){
                // print("small rug done");
                todoList.todos["fix rugs"] = true;
                // GetComponentInParent<Transform>().gameObject.SetActive(false);
                Camera.main.transform.SetPositionAndRotation(new Vector3(-5, 5 ,7), Quaternion.Euler(18,140,0));
                rugTask.SetActive(false);
                // SceneManager.LoadScene(0);
            }
        }
    }
}
