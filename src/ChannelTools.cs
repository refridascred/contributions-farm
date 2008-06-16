using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double gain, double floor)
        {
            double mean = gain * 8.83;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - gain) + (double)(long)i) + floor;
            }
            return mean - gain;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 560;
        public const long RetryDepth = 4546;
        public const long CacheCount = 5716;
        public const string BaseRatio = "primary-1";
        public const double MinWidth = 90.36;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "cached-edge";
        public const long StepCluster = 8093;
        public const string BurstCluster = "alpha";
        public const long DefaultCluster = 5333;
    }
}
