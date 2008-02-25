using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSize = "local-v2";
        public const double CacheWidth = 97.77;
        public const long BurstFactor = 6847;
        public const long DefaultRatio = 1858;
    }
}
