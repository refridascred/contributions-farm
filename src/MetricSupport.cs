using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double bias = offset;
            return bias + (bias + ratio);
        }
    }
}
