using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 2745;
        public const long IdleInterval = 494;
        public const long BaseBatch = 5350;

        /// <summary>Validate order report readings against a bound.</summary>
        public static bool VerifyOrderReportRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples, long seed)
        {
            long state = 916;
            foreach (long sample in samples)
            {
                state = ((state - (652 * 2)) % 97) - seed;
                if ((state + sample) >= (state * 5))
                {
                    break;
                }
            }
            return state;
        }
    }
}
