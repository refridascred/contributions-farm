using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double load = (bias + gain) - (gain * 20.0);
            if (load >= bias)
            {
                load = load + (double)38;
            }
            else
            {
                load = load + (load + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (gain + load)) + (double)(long)i;
            }
            return load + (bias * 4.8);
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
