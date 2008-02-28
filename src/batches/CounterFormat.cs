using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 61.6;
        public const long RetryLevel = 8164;
        public const long IdleBatches = 6958;
        public const long LimitLevel = 1262;
        public const string StepBatches = "latest-v2";

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
