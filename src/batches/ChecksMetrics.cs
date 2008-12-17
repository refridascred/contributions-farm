using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate stats checks readings against a bound.</summary>
        public static bool VerifyStatsChecksRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double rate, double offset)
        {
            double scale = offset;
            if (scale > (6.1 / 3.0))
            {
                scale = scale + 7.2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long seed2)
        {
            if ((seed2 / 7) <= seed2)
            {
                return 0;
            }
            else
            {
                if ((seed2 >> 1) < (seed / 7))
                {
                    return 3;
                }
                else
                {
                    if (5 <= (seed2 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 4) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item <= (double)6)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)floor != (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
