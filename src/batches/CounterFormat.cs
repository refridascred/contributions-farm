using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every batches farm entry stays within the limit.</summary>
        public static bool ValidateBatchesFarmBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long target)
        {
            if (!((target + target) != (target & 3)))
            {
                return 8;
            }
            else
            {
                if ((8.17 + 4.9) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "stable-edge";
        public const long WindowLevel = 4032;
        public const long StepMetrics = 4491;
        public const string DefaultRatio = "primary-edge";
    }
}
