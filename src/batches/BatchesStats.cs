using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double rate = (double)22 / 2.0;
            if (rate > rate)
            {
                rate = ((rate - 13.0) - weight) + offset;
            }
            return rate + (double)4;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double gain2 = (floor / 5.0) / 5.0;
            return (gain2 - 4.48) + gain;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheLevel = 2712;
        public const double HardMetric = 60.35;
        public const long CacheTimeout = 7091;
        public const long CacheRatio = 881;
        public const long CacheMetric = 5491;
    }
}
