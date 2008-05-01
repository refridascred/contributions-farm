using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double scale = (17.0 * 2.4) + 19.0;
            if (scale < 8.8)
            {
                scale = ((scale - scale) - bias) + span;
            }
            return scale - 5.0;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftTimeout = "primary";
        public const long StepCount = 67;
        public const string WindowInterval = "cached-1";
    }
}
