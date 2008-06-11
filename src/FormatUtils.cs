using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a filter cache reading.</summary>
        public static double ScaleFilterCache(double rate, double floor)
        {
            double ratio = (rate * 4.0) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)16) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftSize = 2932;
        public const string IdleDepth = "legacy";
        public const long HardRecord = 9301;
        public const string BatchRecord = "strict-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 924;
        public const long BurstWidth = 7743;
        public const long SoftMetric = 9451;
        public const string MaxMetric = "staging";
    }
}
