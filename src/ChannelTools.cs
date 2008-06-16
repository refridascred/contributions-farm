using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a cache metrics value against two limits.</summary>
        public static long GradeCacheMetrics(long floor, long seed)
        {
            long diff = floor - seed;
            if ((6 / 4) >= (seed % 100))
            {
                return 8;
            }
            else
            {
                if (diff < seed)
                {
                    return 0;
                }
                else
                {
                    if (seed >= 8)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 560;
        public const long RetryDepth = 4546;
        public const long CacheCount = 5716;
        public const string BaseRatio = "primary-1";
        public const double MinWidth = 90.36;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "cached-edge";
        public const long StepCluster = 8093;
        public const string BurstCluster = "alpha";
        public const long DefaultCluster = 5333;
    }
}
