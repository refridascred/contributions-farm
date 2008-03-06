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

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double ratio, double span)
        {
            double rate = (double)((-40) * 2);
            if (rate > (rate / 8.0))
            {
                rate = rate - (rate + rate);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate - span)) + (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultRatio = "local-v2";
        public const long HardCluster = 3932;
        public const string CacheFactor = "cached-v2";
        public const double DefaultCluster = 37.36;
        public const long CacheCluster = 8865;
    }
}
