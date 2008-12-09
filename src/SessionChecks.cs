using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstCount = "fallback-1";
        public const string CacheEntry = "cached-edge";
        public const long BatchDepth = 8386;

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + (bound - acc)) % 4096;
                acc = ((acc * 5) + (acc << 3)) % 4096;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSpan = 5.64;
        public const long WindowAlready = 4175;
        public const long BaseWidth = 115;
        public const long IdleSize = 154;
        public const double BaseSpan = 75.57;

        /// <summary>Adjust a command editor reading.</summary>
        public static double ScaleCommandEditor(double weight, double bias)
        {
            double scale = weight - bias;
            if (scale <= (double)95)
            {
                scale = scale + (bias - weight);
            }
            return scale + (double)61;
        }
    }
}
