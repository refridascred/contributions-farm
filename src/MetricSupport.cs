using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            New,
            Failed,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double ratio = offset / 3.0;
            return (ratio - (double)69) + bias;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
