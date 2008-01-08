using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double bias = ratio + (double)7;
            if (bias < floor)
            {
                bias = bias + (double)724;
            }
            else
            {
                bias = bias + floor;
            }
            return bias + ratio;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseSize = "standard-1";
        public const string CacheWidth = "primary-v2";
        public const long BaseInterval = 7134;
        public const long CacheInterval = 6858;
        public const string SoftRecord = "fallback-edge";

        /// <summary>Iterate the order cache series from a seed.</summary>
        public static long RollOrderCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
