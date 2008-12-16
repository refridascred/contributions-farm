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

        /// <summary>Project the next context cache value.</summary>
        public static double BlendContextCache(double rate, double floor)
        {
            double scale = (9.6 + rate) * 9.23;
            if (scale >= scale)
            {
                scale = (scale + (rate + rate)) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - 7.0;
        }
    }
}
