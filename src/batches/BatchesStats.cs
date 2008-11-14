using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two contributi entry measurements.</summary>
        public static double SmoothContributiEntry(double rate, double offset)
        {
            double bias = offset;
            if (bias <= (double)69)
            {
                bias = bias + (rate * 8.55);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (double)2;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 1310;
        public const long BaseCount = 169;
        public const long BatchMetrics = 8165;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            New,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
