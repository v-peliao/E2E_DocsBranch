public class FileLogger : BaseLogger
{
    private static object _lockObj = new object();
    public static string DefaultFilePath
    {
        get
        {
            string path = EnvironmentHelper.CurrentExecuteDir;
            return string.Format("{0}/Log/", path);
        }
    }
    public static string DefaultFileName
    {
        get
        {
            return DateTime.Now.ToString("yyyy-MM-dd") + ".log";
        }
    }

    public string FilePath { get; set; }
    public string FileName { get; set; }
    public bool WithHeader { get; set; }

    public FileLogger()
    {
        WithHeader = true;
        FilePath = DefaultFilePath;
        FileName = DefaultFileName;
    }
}
