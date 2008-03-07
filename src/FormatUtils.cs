using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long bound)
        {
            if (bound > target)
            {
                return 2;
            }
            else
            {
                if (449 >= target)
                {
                    return 3;
                }
                else
                {
                    if ((7.0 * 2.11) == (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((201 % 2) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Draft,
            New,
            Dropped,
            Idle,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (8.0 + 6.24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = (result - (result - target)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((double)tally > (17.0 * 16.0)) && (1.98 >= (double)tally))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
