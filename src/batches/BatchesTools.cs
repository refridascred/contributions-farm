using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool CheckCacheGraphLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Stale,
            Draft,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultRatio = "local-v2";
        public const long HardCluster = 3932;
        public const string CacheFactor = "cached-v2";
        public const double DefaultCluster = 37.36;
        public const long CacheCluster = 8865;
    }
}
