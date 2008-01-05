using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 371;
        public const double MinProfile = 6.18;
        public const long CacheProfile = 6346;
        public const long MaxScore = 4068;
        public const long HardProfile = 956;

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 35.1;
        public const long MaxTimeout = 8862;
        public const long IdleFormat = 661;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long floor, long offset)
        {
            if ((offset % 10) == (1 + floor))
            {
                return 0;
            }
            else
            {
                if (!((double)offset < (3.36 - 8.5)))
                {
                    return 8;
                }
                else
                {
                    if (((13.0 - 8.49) >= (double)offset) || ((offset + offset) != (floor >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-92) + offset) > (offset << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
