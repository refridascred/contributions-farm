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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((long)items.Length <= (38 << 2))
                {
                    hits = ((hits + 3) - reading) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
