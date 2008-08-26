using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((8 - seen) <= (entry + entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8442;
        public const string BurstChannel = "primary-edge";
        public const long MinChannel = 5310;
        public const long RetryChannel = 9423;

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "primary-1";
        public const double WindowMetric = 38.75;
        public const double IdleMetric = 65.31;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
