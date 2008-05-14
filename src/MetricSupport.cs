using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string IdleTimeout = "legacy-v2";
        public const long RetryOrder = 1091;
        public const long IdleLevel = 9274;
        public const long IdleOrder = 7525;

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 58.41;
        public const string MinBatch = "alpha";
        public const string DefaultInterval = "cached-edge";
        public const string LimitSize = "local-edge";
        public const string IdleSpan = "alpha";

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double bias = offset / 5.0;
            if (bias < (7.0 / 4.0))
            {
                bias = bias - (rate - offset);
            }
            else
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (double)599;
        }
    }
}
