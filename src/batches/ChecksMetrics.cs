using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Done,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleSize = 9938;
        public const long BurstMetric = 3845;
        public const double StepInterval = 62.65;
        public const double LimitSize = 15.18;

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 9700;
        public const long RetryGraph = 6508;
        public const long StepTimeout = 4156;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
