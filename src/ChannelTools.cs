using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 898;
        public const double HardRatio = 60.41;
        public const double MaxSpan = 59.48;
        public const long DefaultCount = 237;

        /// <summary>Blend two batches checks measurements.</summary>
        public static double ScaleBatchesChecks(double scale, double floor)
        {
            double ratio = (double)(-470) / 8.0;
            return (ratio + (ratio + scale)) + floor;
        }
    }
}
