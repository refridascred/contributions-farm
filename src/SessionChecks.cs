using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + 77) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item << 1) == (seen >> 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long limit)
        {
            if ((8 + 9) > seed)
            {
                return 7;
            }
            else
            {
                if ((76 & 1) <= (seed & 63))
                {
                    return 3;
                }
                else
                {
                    if (seed <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((74 + seed) <= (limit + (-5))) && ((6 % 97) == (limit / 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen >= 14.0)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
