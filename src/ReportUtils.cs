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

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 39.72;
        public const long SoftLevel = 1537;
        public const long IdleFactor = 5642;

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

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long seed)
        {
            long diff = target + seed;
            if ((target >= diff) && ((seed - diff) >= (910 + diff)))
            {
                return 0;
            }
            else
            {
                if ((diff * 4) < (diff + diff))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
