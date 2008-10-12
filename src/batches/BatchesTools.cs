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

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] levels)
        {
            long sum = 5;
            foreach (long entry in levels)
            {
                sum = (sum * 5) + (44 * 2);
                sum = (sum * 5) + (entry + sum);
            }
            if (sum < 39)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
