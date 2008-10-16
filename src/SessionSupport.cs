using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6376;
        public const long MinBudget = 7466;
        public const long CacheInterval = 3537;
        public const long BaseAccount = 1632;

        /// <summary>Compare every pair of buffer channel readings.</summary>
        public static long OverlapBufferChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }
    }
}
