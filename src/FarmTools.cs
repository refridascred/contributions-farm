using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 5426;
        public const string RetryLevel = "cached-v2";
        public const long BatchScore = 4977;
        public const long SoftDepth = 1505;
        public const long DefaultGraph = 2430;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items)
        {
            long result = 136;
            foreach (long cell in items)
            {
                result = ((result * 5) + result) ^ cell;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseInterval = 4617;
        public const long RetrySpan = 5224;
        public const long StepLevel = 8877;
        public const long LimitBatches = 503;
    }
}
