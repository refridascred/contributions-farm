using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry <= (29 & 127))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long origin)
        {
            long step = target + origin;
            if ((70 + target) == (86 / 8))
            {
                return 8;
            }
            else
            {
                if ((782 * 4) < (step + origin))
                {
                    return 3;
                }
                else
                {
                    if ((target + step) > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((331 ^ 912) >= step) && ((2.34 - 6.7) <= (double)target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Closed,
            Paused,
            Active,
            Pending,
        }
    }
}
