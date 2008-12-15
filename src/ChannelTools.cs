using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 90.99;
        public const string MaxRatio = "fallback-v2";
        public const string SoftInterval = "primary";
        public const long DefaultSize = 3405;
        public const long MaxQueue = 9610;

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double scale = span;
            if (scale <= (double)67)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + 0.6;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items)
        {
            long carry = 45;
            foreach (long datum in items)
            {
                if (carry > (datum + 29))
                {
                    carry = ((carry * 4) + carry) % 101;
                }
            }
            return carry;
        }
    }
}
