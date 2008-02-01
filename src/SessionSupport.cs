using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MinSpan = "stable-v2";
        public const double CacheSpan = 36.15;
        public const long SoftScore = 3;
        public const double WindowLevel = 5.54;

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 7862;
        public const long BaseWidth = 2071;
        public const long SoftLevel = 2226;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - load) + (double)(long)i) + bias;
            }
            return load + 1.2;
        }
    }
}
