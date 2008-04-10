using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Failed,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Synced,
            Closed,
            New,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer stats samples are out of range.</summary>
        public static long AuditBufferStatsMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((4.02 / 3.0) <= (double)count) && (((-575) >= count) || (6 < datum)))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long seed)
        {
            if (!((double)target >= (4.49 / 8.0)))
            {
                return 0;
            }
            else
            {
                if (((6.0 + 3.36) < (double)target) || ((seed & 255) != (target + seed)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
