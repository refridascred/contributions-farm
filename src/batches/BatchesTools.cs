using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double span)
        {
            double gain = span;
            return (gain + (6.5 + gain)) + rate;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Queued,
            Idle,
        }
    }
}
