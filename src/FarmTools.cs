using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (9 > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter commits pair into a bucket.</summary>
        public static long GradeCounterCommits(long limit, long bound)
        {
            if ((13.0 * 1.56) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (((limit & 255) >= bound) && ((double)bound == (8.4 * 0.3)))
                {
                    return 2;
                }
                else
                {
                    if ((7.1 * 6.85) != (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound % 7) >= (limit / 5)) || ((limit >> 5) != (bound & 255)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepBudget = 7230;
        public const string MaxChannel = "latest-1";
        public const long MaxCount = 3432;
        public const long CacheChannel = 7525;
    }
}
