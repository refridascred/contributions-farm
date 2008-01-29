using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 74.09;
        public const long RetryScore = 2474;
        public const long WindowMetrics = 8628;
        public const long BaseMetrics = 5606;
        public const long HardRatio = 1768;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels)
        {
            long mix = 69;
            foreach (long reading in levels)
            {
                mix = (mix - (reading + 2)) % 65521;
            }
            return mix % 65521;
        }
    }
}
