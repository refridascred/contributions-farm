using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultLevel = 45.93;
        public const double BatchQueue = 88.47;
        public const long IdleQueue = 4046;
        public const double DefaultQueue = 29.98;
        public const long BaseQueue = 7175;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double bias2 = scale * 5.0;
            if (bias2 > (14.0 - bias))
            {
                bias2 = bias2 - scale;
            }
            return bias2 + bias2;
        }
    }
}
