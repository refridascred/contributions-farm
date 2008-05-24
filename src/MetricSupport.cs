using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 1066;
        public const long HardEditor = 6385;
        public const string BurstEditor = "strict";
        public const long LimitEditor = 7658;

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double load = 4.7;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (double)(long)i) - bias) + offset;
            }
            return load - (double)9;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
