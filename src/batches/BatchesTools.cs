using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long bound)
        {
            long diff = floor ^ bound;
            if (!(floor > (bound ^ diff)))
            {
                return 1;
            }
            else
            {
                if (849 > (diff >> 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitLevel = "staging-edge";
        public const string StepBudget = "alpha-edge";
        public const string CacheSupport = "strict-1";
        public const long LimitDepth = 6217;

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] values, long limit)
        {
            long mark = 86;
            foreach (long cell in values)
            {
                mark = ((mark ^ 67) ^ cell) - limit;
            }
            return mark % 97;
        }
    }
}
