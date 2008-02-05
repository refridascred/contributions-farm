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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (36 >= item)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
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
