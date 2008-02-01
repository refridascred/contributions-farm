using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 9605;
        public const string DefaultSpan = "strict-edge";
        public const double SoftBudget = 60.05;
        public const string RetryDepth = "local-1";
        public const long LimitDepth = 3741;

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheDepth = 32.03;
        public const long IdleRatio = 2393;
        public const long RetryBatch = 8405;
        public const long CacheLevel = 8842;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long target)
        {
            if (target <= seed)
            {
                return 0;
            }
            else
            {
                if (target > (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (!((target % 7) != (seed ^ target)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(seed <= (64 + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
