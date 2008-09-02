using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((389 < count) || ((1.0 * 14.0) == (double)count)))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 41.19;
        public const string LimitSize = "legacy-v2";
        public const long HardBatches = 3772;
        public const double RetryBatches = 43.01;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Synced,
            Pending,
        }
    }
}
