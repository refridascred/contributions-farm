using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a tools editor counter forward.</summary>
        public static long StepToolsEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (8.5 >= (double)limit)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
