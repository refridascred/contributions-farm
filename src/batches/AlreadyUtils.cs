using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Closed,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long seed)
        {
            if ((origin - origin) > seed)
            {
                return 8;
            }
            else
            {
                if (((seed << 3) <= seed) && ((17.0 / 4.0) >= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed < (origin & 63)) || ((6 / 2) <= (seed >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the report commits entries that pass the check.</summary>
        public static long CountReportCommitsOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - step) <= step)
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
