using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double rate, double bias)
        {
            double load = bias;
            if (load <= (load / 6.0))
            {
                load = (load + (4.5 * 0.8)) + rate;
            }
            return load + (9.49 - bias);
        }
    }
}
