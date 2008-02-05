using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string RetryWidth = "strict-v2";
        public const string MaxToken = "latest";
        public const long StepSize = 4289;
        public const long SoftToken = 3768;
        public const long MaxWidth = 7258;

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3743;
        public const long MaxBatch = 2502;
        public const string LimitBudget = "primary-v2";
        public const string RetryFactor = "legacy-edge";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long seed, long seed2)
        {
            long offset = seed + seed2;
            if (((offset / 2) != (offset - seed)) && ((double)11 < (double)seed2))
            {
                return 5;
            }
            else
            {
                if (!(offset > (offset << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((128 >> 5) <= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed2 + seed2) == (offset & 7)) && ((double)18 > (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route counter input into a small class.</summary>
        public static long RankRouteCounter(long floor, long bound)
        {
            if (((1.5 + 10.0) <= (double)bound) && ((floor >> 2) < 399))
            {
                return 2;
            }
            else
            {
                if ((bound > floor) && ((12.0 / 6.0) < (8.0 + 6.11)))
                {
                    return 4;
                }
                else
                {
                    if (!(9.8 > (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
