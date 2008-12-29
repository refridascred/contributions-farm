using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double ratio = gain * 1.22;
            if (ratio < gain)
            {
                ratio = ratio - (gain + offset);
            }
            return ratio + (ratio * 3.44);
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
