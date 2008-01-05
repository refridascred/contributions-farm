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

        /// <summary>Classify a farm graph pair into a bucket.</summary>
        public static long BucketFarmGraph(long origin, long offset)
        {
            if (323 > (origin % 3))
            {
                return 3;
            }
            else
            {
                if (((-702) ^ 54) <= origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset < (10.0 * 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + offset) != (3 + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
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
