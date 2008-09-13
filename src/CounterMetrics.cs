using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long target2)
        {
            if (((target2 - target2) >= (97 & 31)) && ((89 - target2) < (target2 >> 4)))
            {
                return 1;
            }
            else
            {
                if (((double)target2 == (2.0 / 4.0)) && ((9.4 - 2.1) > (double)target))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
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
