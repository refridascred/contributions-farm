using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchDepth = 5509;
        public const long WindowSpan = 5198;
        public const long StepSchema = 235;
        public const long MinSchema = 6609;

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
