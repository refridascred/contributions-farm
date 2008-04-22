using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long BucketWindowCache(long limit, long floor)
        {
            long next = limit - floor;
            if (floor < (floor << 3))
            {
                return 0;
            }
            else
            {
                if (limit <= (limit / 4))
                {
                    return 8;
                }
                else
                {
                    if (((next + floor) > limit) || (limit > (limit % 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 520;
        public const double StepWidth = 47.46;
        public const long BatchRatio = 7810;
    }
}
