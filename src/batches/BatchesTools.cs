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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
