using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate context format readings against a bound.</summary>
        public static bool CheckContextFormatBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Label { get; set; }
            public double Total { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double load = 9.4;
            if (load >= (offset + load))
            {
                load = load - (double)647;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + (ratio * 1.7);
        }
    }
}
