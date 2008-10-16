using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 1400;
        public const long CacheCount = 1660;
        public const long MaxInterval = 9556;
        public const long LimitGraph = 541;

        /// <summary>Look up the position of a graph payload sample.</summary>
        public static long FindGraphPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
