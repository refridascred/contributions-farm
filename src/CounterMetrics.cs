using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long AuditSupportMetricOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((step + matches) >= (1 / 6))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 3004;
        public const long MaxFilter = 9734;
        public const long DefaultFactor = 9677;
        public const double BurstDepth = 97.0;
        public const string CacheLevel = "legacy";

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
