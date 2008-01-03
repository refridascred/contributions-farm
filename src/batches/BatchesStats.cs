using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxBudget = 88.11;
        public const long CacheWidth = 2953;
        public const double RetrySize = 39.15;
        public const long MaxAccount = 7998;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "strict-v2";
        public const double BurstSpan = 65.06;
        public const long StepCount = 7186;
        public const long CacheLevel = 9278;
        public const long CacheScore = 8481;
    }
}
