using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 2756;
        public const long HardScore = 9732;
        public const long LimitLevel = 2862;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
