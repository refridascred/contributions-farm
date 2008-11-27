using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitInterval = 609;
        public const long CacheSize = 8948;
        public const long BurstFactor = 7852;
    }
}
