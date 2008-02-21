using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long offset, long offset2)
        {
            if ((offset2 % 3) == (offset - offset))
            {
                return 6;
            }
            else
            {
                if ((offset / 8) < (offset2 * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset <= (9.7 - 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
