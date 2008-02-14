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

        /// <summary>Adjust a support cache reading.</summary>
        public static double ProjectSupportCache(double scale, double floor)
        {
            double mean = (double)(17 * 5);
            if (mean < scale)
            {
                mean = (mean + (scale * 2.88)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - scale;
        }
    }
}
