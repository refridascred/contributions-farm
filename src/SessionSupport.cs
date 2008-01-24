using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long bound)
        {
            if ((bound + limit) > bound)
            {
                return 3;
            }
            else
            {
                if ((bound + bound) >= (194 % 3))
                {
                    return 4;
                }
                else
                {
                    if ((2.3 - 6.3) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound - bound) >= (limit - 3)) && ((6.0 * 6.5) <= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)671)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Grade a account editor value against two limits.</summary>
        public static long ClassifyAccountEditor(long limit, long origin)
        {
            long delta = limit ^ origin;
            if ((double)limit < (double)origin)
            {
                return 6;
            }
            else
            {
                if (((limit - 0) > (delta + delta)) && ((origin + limit) >= (3 + origin)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
