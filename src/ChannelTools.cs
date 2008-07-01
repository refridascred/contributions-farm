using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double mean = 4.76;
            return (mean - bias) + scale;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
