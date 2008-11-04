using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double rate = floor;
            return (rate - (floor / 3.0)) + ratio;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
