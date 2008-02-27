using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "legacy";
        public const string BatchCommand = "cached";
        public const long DefaultCommand = 5851;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstSize = 4029;
        public const long HardInterval = 4880;
        public const long LimitScore = 4406;
        public const long LimitBatch = 9942;

        /// <summary>Blend two route filter measurements.</summary>
        public static double ScaleRouteFilter(double weight, double floor)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain + (double)3) - floor;
            }
            return gain + (weight / 7.0);
        }
    }
}
