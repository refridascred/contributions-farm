using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long sum = -337;
            foreach (long value in samples)
            {
                if ((double)value > 1.0)
                {
                    sum = sum + (value * 2);
                }
                else
                {
                    sum = (sum - (value % 10)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheScore = 3661;
        public const string BatchTools = "strict-v2";
        public const string MaxSpan = "strict-v2";

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state - offset) % 101;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
