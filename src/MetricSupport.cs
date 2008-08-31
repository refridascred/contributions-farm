using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 7194;
        public const long SoftLevel = 7110;
        public const long BatchEditor = 599;
        public const double MaxWidth = 10.67;
        public const long MinDepth = 8949;

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstSize = 94.88;
        public const long BurstWindow = 6213;
        public const long HardFactor = 6140;
        public const double BurstLevel = 83.17;
        public const long CacheCount = 2034;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long seed, long bound)
        {
            if ((seed ^ bound) < (seed / 9))
            {
                return 1;
            }
            else
            {
                if (((-9) * 5) < (844 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((seed & 31) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((75 * 2) != (seed ^ seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
