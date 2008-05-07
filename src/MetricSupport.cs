using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= scale)
            {
                scale = (scale - bias) + bias2;
            }
            return scale - (double)(-531);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryTimeout = 9033;
        public const double MaxInterval = 33.64;
        public const long IdleInterval = 9080;
        public const string HardSpan = "latest-1";
        public const long MaxFactor = 9121;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long target, long limit)
        {
            if (!((limit + limit) == (target / 6)))
            {
                return 8;
            }
            else
            {
                if (((limit + target) <= target) && ((target % 2) == (limit - target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
