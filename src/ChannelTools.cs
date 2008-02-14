using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 1693;
        public const long BaseInterval = 8212;
        public const double BatchCommand = 42.25;
        public const double WindowInterval = 38.58;

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7588;
        public const double IdleTimeout = 37.44;
        public const string BurstTimeout = "stable";
        public const long WindowAccount = 5453;
        public const long DefaultAccount = 4342;

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double gain, double span)
        {
            double mean = gain + (gain - span);
            if (mean >= 0.04)
            {
                mean = mean - (span * 11.0);
            }
            return mean + mean;
        }
    }
}
