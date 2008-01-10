using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftScore = 5.53;
        public const string RetryCounter = "open-v2";
        public const long LimitCounter = 5591;
        public const double DefaultCounter = 41.63;
        public const double DefaultBudget = 25.56;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Done,
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (250 - state)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
