namespace FileUploader.Models
{
    public class AzureStorageConfig
    {
        public AzureStorageConfig()
        {
            //ConnectionString = "DefaultEndpointsProtocol=https;EndpointSuffix=core.windows.net;AccountName=antenasa;AccountKey=gI061dKPINCEeYjyyMlZtPEJGg8hBiMn5iHL5OovCliU0VedFl1+c25Q5oxWpuLIZMo4qr/1z491pVogDlpM0w==";
            //FileContainerName = "files";
            //AnalyzedFileContainerName = "analyzed";
        }

        public string ConnectionString { get; set; }
        public string FileContainerName { get; set; }
        public string AnalyzedFileContainerName { get; set; }
    }
}