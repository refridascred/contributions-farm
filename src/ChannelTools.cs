using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] data, long floor)
        {
            long state = 491;
            foreach (long entry in data)
            {
                if ((entry > (state >> 4)) && ((entry & 1) <= 0))
                {
                    state = (state - floor) % 255;
                }
                else
                {
                    state = state - (state * 5);
                }
            }
            if (state < 899)
            {
                state = state - (state * 3);
            }
            return state % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowFactor = 5223;
        public const long CacheStats = 4807;
        public const long HardStats = 2577;
        public const string WindowStats = "primary-1";
        public const string CacheBudget = "stable-edge";

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double rate = 6.5;
            if (rate < (rate - gain))
            {
                rate = rate - bias;
            }
            return rate - (double)27;
        }
    }
}
