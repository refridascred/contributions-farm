using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 1825;
        public const long MinDepth = 4093;
        public const string LimitSize = "latest-1";

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double load = bias;
            if (load > (load * 9.0))
            {
                load = load - (load - weight);
            }
            return load + (load + weight);
        }
    }
}
