using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;
    public Scene sceneToLoad;

    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        Scene1,
        Scene2
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad.ToString());
    }
}
