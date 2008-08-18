using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 8185;
        public const long MinMetrics = 8436;
        public const long StepMetrics = 9993;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double mean = weight;
            return mean + floor;
        }
    }
}
