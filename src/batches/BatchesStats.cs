using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Draft,
            Idle,
            Queued,
            Stale,
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

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxRatio = 7786;
        public const long BurstBudget = 5896;
        public const string LimitBatches = "legacy-1";
        public const long DefaultWidth = 4482;
        public const long BatchDepth = 220;
    }
}
