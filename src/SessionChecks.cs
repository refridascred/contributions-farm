using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long offset)
        {
            long lane = target - offset;
            if ((target - 610) > (target << 1))
            {
                return 2;
            }
            else
            {
                if (lane <= (2 + target))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((reading << 1) >= (100 * 5)) && !((tally << 2) >= (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            New,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long floor, long origin)
        {
            long diff = floor - origin;
            if ((diff - floor) != (820 ^ floor))
            {
                return 0;
            }
            else
            {
                if (origin >= (diff >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
