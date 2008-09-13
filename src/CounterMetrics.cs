using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item ^ hits) <= (hits ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            New,
            Retry,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Closed,
            Active,
            Draft,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 8666;
        public const double MaxTimeout = 65.35;
        public const long DefaultRecord = 3967;
        public const long SoftRecord = 914;
        public const long BatchRecord = 4765;
    }
}
