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

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = (state - ((long)i << 2)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
