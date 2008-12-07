using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double rate, double offset)
        {
            double drift = offset + rate;
            return drift - (rate - drift);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseSpan = "fallback";
        public const long DefaultAccount = 1645;
        public const long WindowAccount = 7163;
        public const string CacheSize = "standard";
        public const long BatchFactor = 6561;

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFactor = 978;
        public const double BatchFormat = 94.35;
        public const long BaseFormat = 8980;
        public const long RetryFormat = 9098;
        public const double SoftFactor = 23.91;
    }
}
