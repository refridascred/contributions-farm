using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count window commits pairs that satisfy a relation.</summary>
        public static long CompareWindowCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 52.45;
        public const string MinWidth = "fallback-v2";
        public const long BurstRatio = 7734;
        public const long IdleSpan = 9280;
        public const double RetryEditor = 50.76;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long seed, long offset)
        {
            long step = seed - offset;
            if (!((double)step <= (4.5 + 2.0)))
            {
                return 4;
            }
            else
            {
                if ((offset - offset) <= (step + offset))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
