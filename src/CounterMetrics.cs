using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batch route input into a small class.</summary>
        public static long BucketBatchRoute(long bound, long bound2)
        {
            if (bound < (bound2 + 98))
            {
                return 5;
            }
            else
            {
                if ((6 - bound2) >= bound2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 6395;
        public const long BaseRatio = 4688;
        public const long StepSize = 8188;

        /// <summary>Classify a metric queue pair into a bucket.</summary>
        public static long GradeMetricQueue(long limit, long target)
        {
            if ((519 >> 1) <= (target >> 5))
            {
                return 4;
            }
            else
            {
                if ((target - target) > (target >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (20.0 * 7.0))
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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if (result >= (long)i)
                {
                    result = (result * 5) + (seed / 7);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
