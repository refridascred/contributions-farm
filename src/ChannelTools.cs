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

        /// <summary>Project the next buffer contributi value.</summary>
        public static double ProjectBufferContributi(double weight, double bias)
        {
            double scale = 8.3;
            if (scale <= (double)12)
            {
                scale = scale + bias;
            }
            return scale + weight;
        }
    }
}
