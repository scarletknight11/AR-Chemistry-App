using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour {

    private Dictionary<string, bool> elementsStatus = new Dictionary<string, bool>();


    // Start is called before the first frame update
    void Start()
    {
        elementsStatus.Add("H", false);
        elementsStatus.Add("o", false);
    }

    public void ElementActivated(string name)
    {
        elementsStatus[name] = true;
    }

    public void ElementDecativated(string name)
    {
        elementsStatus[name] = false;
    }

    public bool IsElementActive(string name)
    {
        return elementsStatus[name] == true;
    }

}
