using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSize = 8999;
        public const long SoftBudget = 3392;
        public const string BurstLayout = "fallback-edge";
        public const long BatchTimeout = 2402;
        public const string MinInterval = "alpha-1";

        /// <summary>Blend two command route measurements.</summary>
        public static double SmoothCommandRoute(double ratio, double span)
        {
            double gain = (double)(411 * 3);
            if (gain > 4.8)
            {
                gain = ((gain + gain) - ratio) - span;
            }
            else
            {
                gain = gain + (double)267;
            }
            return gain - (gain * 2.67);
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double rate = 19.0 - (span * 0.7);
            if (rate > (ratio / 8.0))
            {
                rate = rate + (0.3 * 8.51);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate + 14.0;
        }
    }
}
