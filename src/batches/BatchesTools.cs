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

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double span)
        {
            double ratio = (double)621 + span;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 2.22) + (double)(long)i;
            }
            return ratio - (ratio + rate);
        }
    }
}
