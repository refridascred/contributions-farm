using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long mix = 36;
            foreach (long value in items)
            {
                if ((target + mix) <= target)
                {
                    mix = ((mix * 5) + 744) ^ value;
                }
            }
            if (mix < 51)
            {
                mix = mix + (target << 1);
            }
            return mix;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= (tally << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "standard";
        public const string IdleBatch = "latest-v2";
        public const long RetryWidth = 6821;
    }
}
