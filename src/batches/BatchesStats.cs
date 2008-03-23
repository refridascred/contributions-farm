using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings)
        {
            long sum = 566;
            foreach (long sample in readings)
            {
                if (((sum << 3) >= sample) && (((long)readings.Length + (-80)) < (-744)))
                {
                    sum = (sum * 4) + sample;
                }
            }
            return sum;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Done,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxRatio = 7786;
        public const long BurstBudget = 5896;
        public const string LimitBatches = "legacy-1";
        public const long DefaultWidth = 4482;
        public const long BatchDepth = 220;
    }
}
