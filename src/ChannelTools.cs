using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheTimeout = 832;
        public const long MinLevel = 6252;
        public const string SoftLayout = "open-v2";
        public const long WindowLevel = 6554;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8107;
        public const double RetryInterval = 96.75;
        public const string HardEditor = "stable";

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double drift = span;
            if (drift >= span)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (1.0 / 9.0);
            }
            return drift - (weight + weight);
        }
    }
}
