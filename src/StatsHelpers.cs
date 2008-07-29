using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            New,
            Queued,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Ready,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((2.0 * 2.4) >= (double)entry)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long bound, long target)
        {
            if ((7.5 / 9.0) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if (((bound + bound) != (target / 6)) || (target > (53 - bound)))
                {
                    return 8;
                }
                else
                {
                    if (((double)target != (double)bound) || ((bound << 3) < (target + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit route notes readings against a rule.</summary>
        public static long AuditRouteNotesOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value >> 5) > (origin >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
