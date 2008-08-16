using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultFactor = 2977;
        public const double CacheWindow = 42.54;
        public const long MinWindow = 8181;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long result = 66;
            foreach (long cell in values)
            {
                if (!((cell - (-702)) <= (358 & 63)))
                {
                    result = (((result << 3) ^ cell) % 1000) - seed;
                }
                else
                {
                    result = result ^ (cell >> 2);
                }
            }
            return result;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long target)
        {
            if (seed > (target * 2))
            {
                return 8;
            }
            else
            {
                if ((target ^ 25) == (target - target))
                {
                    return 1;
                }
                else
                {
                    if ((seed ^ target) >= (seed + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
