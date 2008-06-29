using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long bound)
        {
            if (floor < (bound >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor ^ 201) < floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
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
