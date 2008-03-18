using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 7272;
        public const long BatchInterval = 990;
        public const long RetryWidth = 84;
        public const long RetryGraph = 8012;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((3.5 - 1.0) != (double)seen)
                {
                    seen = ((seen + 3) ^ sample) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }
    }
}
