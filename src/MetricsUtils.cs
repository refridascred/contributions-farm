using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Failed,
            New,
            Paused,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                result = (((result << 2) ^ (33 % 24)) % 65521) + sample;
            }
            return result % 1000;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
