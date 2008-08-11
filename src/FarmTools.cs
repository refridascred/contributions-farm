using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account route readings against a rule.</summary>
        public static long AuditAccountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((15 ^ matches) <= (matches << 1))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long seed)
        {
            if ((double)seed < (7.96 / 8.0))
            {
                return 0;
            }
            else
            {
                if ((double)seed > (3.4 * 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((11.0 - 14.0) >= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor + seed) < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route stream samples are out of range.</summary>
        public static long AuditRouteStreamMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((71 & 3) >= ((long)readings.Length - floor)) || (floor >= matches))
                {
                    matches = (matches + 2) - cell;
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
