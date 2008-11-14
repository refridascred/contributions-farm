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

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 91.16;
        public const double RetryBatches = 42.47;
        public const double StepLevel = 37.59;
        public const long SoftRatio = 613;

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
