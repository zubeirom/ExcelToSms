using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelToSms
{
    public interface IExtractor
    {
        List<T> extract<T>(string filePath);
    }
}
