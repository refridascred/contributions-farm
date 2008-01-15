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

        /// <summary>Fold a list of farm record readings.</summary>
        public static long FoldFarmRecord(long[] readings, long offset)
        {
            long sum = 51;
            foreach (long reading in readings)
            {
                if (((reading * 2) != (offset % 7)) && ((13.0 * 0.4) < (double)sum))
                {
                    sum = (sum + sum) % 101;
                    sum = ((sum << 3) ^ (373 * 2)) % 97;
                }
                if ((10 - sum) != (offset - sum))
                {
                    sum = sum + (offset / 4);
                }
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((bound >> 5) < bound) && ((bound & 7) > 256))
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
