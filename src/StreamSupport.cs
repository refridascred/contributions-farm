using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleTimeout = 8397;
        public const double StepOrder = 93.55;
        public const long MaxLevel = 23;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Blend two tools graph measurements.</summary>
        public static double AdjustToolsGraph(double weight, double span)
        {
            double gain = (span * 2.9) / 4.0;
            return (gain - (1.4 * 5.34)) + weight;
        }
    }
}
