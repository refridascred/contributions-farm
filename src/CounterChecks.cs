using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitBudget = 5298;
        public const string StepCluster = "legacy-1";
        public const long SoftDepth = 334;
        public const long IdleCluster = 7010;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (11.0 / 6.0))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "legacy-1";
        public const string BaseWidth = "legacy-v2";
        public const string CacheTimeout = "standard-edge";
        public const long BurstOrder = 2839;

        /// <summary>Accumulate cluster metrics samples.</summary>
        public static long TallyClusterMetrics(long[] series, long step)
        {
            long total = 750;
            foreach (long sample in series)
            {
                total = (((total - (total << 2)) % 65521) - sample) - step;
            }
            return total;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Stale,
            Queued,
            Pending,
        }
    }
}
