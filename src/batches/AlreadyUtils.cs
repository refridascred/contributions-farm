using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long bound)
        {
            long gap = seed - bound;
            if ((double)bound > (5.76 * 6.5))
            {
                return 8;
            }
            else
            {
                if (((bound * 3) <= gap) && ((double)gap > (8.6 / 3.0)))
                {
                    return 0;
                }
                else
                {
                    if (((seed & 3) <= seed) && ((2 * 2) == (gap ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((8.6 + 7.41) == (double)gap))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches == (9.15 / 7.0))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats payload entry stays within the limit.</summary>
        public static bool GuardStatsPayloadRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((3.07 * 13.0) > (double)cell) || (cell > (cell >> 3))) || ((double)cell != (7.9 * 6.8)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if (6.23 < (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((0.54 / 6.0) != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
