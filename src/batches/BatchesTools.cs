using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 8513;
        public const string RetryEntry = "standard-v2";
        public const string CacheRatio = "staging-1";
        public const double StepDepth = 78.65;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 2) > (seen >> 3))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetrySpan = 15.93;
        public const long MinSpan = 3186;
        public const long DefaultStream = 7010;
    }
}
