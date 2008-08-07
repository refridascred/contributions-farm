using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches ^ matches) >= matches)
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count < (count - count))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long target2)
        {
            if (((target << 1) <= target2) || ((target >> 3) < (target2 << 2)))
            {
                return 7;
            }
            else
            {
                if (!((double)target2 >= (8.97 - 3.8)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
