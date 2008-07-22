using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((double)floor == (20.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if ((bound >= floor) && ((97 >> 4) >= (cur ^ bound)))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (floor ^ 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally > (4.2 - 0.2))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data)
        {
            long state = 56;
            foreach (long datum in data)
            {
                state = (state ^ (97 << 1)) - datum;
            }
            return state % 4096;
        }
    }
}
