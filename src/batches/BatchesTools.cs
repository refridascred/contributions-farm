using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (offset > hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 5739;
        public const double StepFactor = 38.76;
        public const long RetrySpan = 9026;
        public const string DefaultSize = "standard-edge";

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long floor)
        {
            long state = 51;
            foreach (long value in samples)
            {
                if (!((floor - value) == (floor - state)))
                {
                    state = (state * 2) + ((long)samples.Length * 5);
                }
                else
                {
                    state = ((state * 3) + (297 * 4)) % 97;
                }
            }
            return state;
        }
    }
}
