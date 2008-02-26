using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Scale a order format figure with a bias.</summary>
        public static double SmoothOrderFormat(double bias, double bias2)
        {
            double scale = (double)(23 % 7);
            if (scale >= (scale - bias2))
            {
                scale = (scale - (0.49 * 10.0)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)579) + (double)(long)i;
            }
            return scale + (scale + scale);
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
