using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two metric tools measurements.</summary>
        public static double BlendMetricTools(double scale, double span)
        {
            double rate = span;
            if (rate >= (scale - span))
            {
                rate = rate - scale;
            }
            return rate - (span + rate);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8026;
        public const long LimitProfile = 6011;
        public const double MaxProfile = 77.96;
        public const long HardCount = 1820;

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double rate = (double)(46 << 2);
            if (rate < (bias / 9.0))
            {
                rate = (rate + (rate - rate)) - span;
            }
            return rate + rate;
        }
    }
}
