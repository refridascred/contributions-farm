using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long step, long floor)
        {
            if (floor <= (floor + floor))
            {
                return 0;
            }
            else
            {
                if ((floor ^ floor) == (step % 97))
                {
                    return 2;
                }
                else
                {
                    if ((step - step) <= (floor - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor << 1) > floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long target)
        {
            long offset = seed ^ target;
            if (target > (offset - 7))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (16.0 + 1.09))
                {
                    return 0;
                }
                else
                {
                    if (target < (6 + 411))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 8623;
        public const double CacheMetrics = 69.09;
        public const double BatchMetrics = 50.0;
        public const long SoftInterval = 4085;
        public const long StepCount = 1176;
    }
}
