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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long target, long step)
        {
            if ((step - 96) < (step / 4))
            {
                return 6;
            }
            else
            {
                if (756 < step)
                {
                    return 0;
                }
                else
                {
                    if ((target << 3) == (target / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
