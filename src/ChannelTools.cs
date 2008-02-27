using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "legacy";
        public const string BatchCommand = "cached";
        public const long DefaultCommand = 5851;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstSize = 4029;
        public const long HardInterval = 4880;
        public const long LimitScore = 4406;
        public const long LimitBatch = 9942;

        /// <summary>Locate a command commits reading by value.</summary>
        public static long SeekCommandCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
