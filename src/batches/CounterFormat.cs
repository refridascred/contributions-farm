using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 110;
        public const long CacheAlready = 5831;
        public const long CacheDepth = 2842;
        public const long MinAlready = 9780;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }
    }
}
