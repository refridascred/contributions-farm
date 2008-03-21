using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a cluster context counter forward.</summary>
        public static long RollClusterContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 38.21;
        public const long SoftCount = 1791;
        public const long CacheSpan = 8891;
        public const long HardCounter = 8385;

        /// <summary>Blend two format report measurements.</summary>
        public static double BlendFormatReport(double weight, double bias)
        {
            double scale = (weight / 7.0) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias - bias)) - (double)(long)i;
            }
            return scale + (bias * 6.0);
        }
    }
}
