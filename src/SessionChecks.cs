using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank graph filter input into a small class.</summary>
        public static long RankGraphFilter(long floor, long step)
        {
            if (!((step * 2) < step))
            {
                return 3;
            }
            else
            {
                if ((step + floor) > floor)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long limit, long seed)
        {
            if (((seed + limit) <= 97) || ((seed & 3) >= seed))
            {
                return 0;
            }
            else
            {
                if ((double)825 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) >= (limit * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((9.33 + 9.83) < (double)seed) && (7 <= seed))
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
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((13.0 + 4.09) == (double)step))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
