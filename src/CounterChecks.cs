using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long limit)
        {
            long state = 3;
            foreach (long sample in data)
            {
                if ((sample + state) <= sample)
                {
                    state = state - limit;
                }
            }
            return state;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "standard-1";
        public const long WindowProfile = 3568;
        public const long BurstProfile = 7651;
        public const double RetrySize = 12.51;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 7028;
        public const string WindowFilter = "open";
        public const long BaseBudget = 3491;
        public const long CacheTimeout = 1415;
        public const long LimitFilter = 6959;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a queue filter value against two limits.</summary>
        public static long SortQueueFilter(long limit, long target)
        {
            long cur = limit - target;
            if (cur < (target / 5))
            {
                return 0;
            }
            else
            {
                if ((cur << 3) == (112 >> 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
