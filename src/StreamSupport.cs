using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long target2)
        {
            if (target > (target + target))
            {
                return 2;
            }
            else
            {
                if (target2 >= (target - 6))
                {
                    return 1;
                }
                else
                {
                    if ((target2 % 7) == (target << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSize = "local-v2";
        public const double CacheWidth = 97.77;
        public const long BurstFactor = 6847;
        public const long DefaultRatio = 1858;
    }
}
