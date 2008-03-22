using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 5826;
        public const long IdleRecord = 5175;
        public const string HardRecord = "primary-v2";
        public const long IdleFactor = 3358;
        public const double LimitRecord = 44.78;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Pending,
            Idle,
            New,
        }
    }
}
