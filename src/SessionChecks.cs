using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long seed, long bound)
        {
            long slot = seed + bound;
            if (((57 & 255) <= (bound + 235)) && ((slot % 3) > ((-62) / 7)))
            {
                return 3;
            }
            else
            {
                if ((640 + bound) > (bound + bound))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long origin, long offset)
        {
            long step = origin + offset;
            if ((step << 2) < (step * 3))
            {
                return 4;
            }
            else
            {
                if ((step - 77) <= (offset + offset))
                {
                    return 1;
                }
                else
                {
                    if ((step ^ step) <= (32 + 65))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + origin) >= origin)
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

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1424;
        public const double MinCommand = 18.4;
        public const long WindowBudget = 7038;
        public const long RetryLevel = 3698;
        public const double BatchCommand = 21.16;

        /// <summary>Classify a metric batches pair into a bucket.</summary>
        public static long BucketMetricBatches(long limit, long step)
        {
            long prev = limit - step;
            if ((limit % 24) > (782 + prev))
            {
                return 5;
            }
            else
            {
                if ((limit >= (step - 21)) && ((prev + 2) < step))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
