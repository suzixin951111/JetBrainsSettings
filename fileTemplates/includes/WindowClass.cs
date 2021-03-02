using UnityEngine;
using UnityEngine.UI;

public class ${NAME} : BaseWindow
{
    //------------------控件定义Start------------------//
    //------------------控件定义End--------------------//
    
    public override WinLayer layer => WinLayer.Normal;

    public override string resName => throw new Exception("未定义资源名");

    protected override void OnCreate()
    {
    }
    
    protected override void OnOpen()
    {
    }
    
    protected override void onClose()
    {
    }
    
    
}
