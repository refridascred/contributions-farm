using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryTimeout = 2028;
        public const long BaseRoute = 7046;
        public const long DefaultCount = 8199;
        public const long BatchRoute = 7433;
        public const long DefaultFactor = 4494;

        /// <summary>Check that every notes cache entry stays within the limit.</summary>
        public static bool GuardNotesCacheRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > 3.1)
            {
                bias2 = (bias2 + (double)24) + bias;
            }
            return bias2 - (double)0;
        }
    }
}
