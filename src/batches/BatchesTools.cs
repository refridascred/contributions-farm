using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values)
        {
            long sum = 60;
            foreach (long reading in values)
            {
                if ((5.7 - 9.7) < (double)reading)
                {
                    sum = ((sum << 2) ^ reading) % 1000;
                }
                if ((sum & 31) == (1 & 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepScore = 1643;
        public const string RetryDepth = "staging-1";
        public const long BatchWindow = 9670;
        public const long DefaultSpan = 4435;
    }
}
