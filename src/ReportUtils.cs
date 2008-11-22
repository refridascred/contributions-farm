using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((497 > (item & 63)) && ((tally / 3) == (tally * 4)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = state - (offset + (long)i);
                if ((7.53 / 7.0) == (double)(long)i)
                {
                    state = ((state << 3) ^ (offset / 3)) % 65521;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if ((4.8 / 6.0) != (double)step)
                {
                    total = (total << 3) ^ ((long)i & 63);
                    total = (total ^ ((long)i ^ 355)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a tools session value against two limits.</summary>
        public static long RankToolsSession(long origin, long origin2)
        {
            if ((origin & 63) > (3 * 2))
            {
                return 6;
            }
            else
            {
                if ((double)origin < (3.67 - 4.5))
                {
                    return 2;
                }
                else
                {
                    if ((74 & 3) == (origin + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (267 <= (origin - 39))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double scale = floor;
            if (scale < (double)58)
            {
                scale = scale + gain;
            }
            return scale + (floor + scale);
        }
    }
}
