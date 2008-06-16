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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((6.13 - 5.3) >= (double)cell)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
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
