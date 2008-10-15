using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a filter farm value against two limits.</summary>
        public static long BucketFilterFarm(long step, long seed)
        {
            if ((step & 31) > (seed + step))
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (8.0 + 9.0)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long floor)
        {
            if (((floor / 6) != (349 & 15)) || ((4.0 + 4.01) == (double)floor))
            {
                return 4;
            }
            else
            {
                if ((0 + origin) == (origin << 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 3836;
        public const string DefaultInterval = "alpha";
        public const long BaseScore = 4335;
        public const long BurstCache = 7453;
    }
}
