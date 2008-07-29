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

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] levels, long target)
        {
            long mix = 558;
            foreach (long value in levels)
            {
                if (((value + target) > (target - mix)) || (target <= (value ^ 44)))
                {
                    mix = ((mix * 5) + (508 * 5)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ (mix - 30);
                }
            }
            return mix % 4096;
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
