using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheFactor = 6183;
        public const double CacheRatio = 90.71;
        public const string LimitBudget = "staging-edge";

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double gain, double bias)
        {
            double ratio = (7.8 - gain) / 8.0;
            if (ratio >= bias)
            {
                ratio = ratio - bias;
            }
            return ratio + (double)(-2);
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
