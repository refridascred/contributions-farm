using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - (double)14) + bias;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
