using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of report already readings.</summary>
        public static long OverlapReportAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
