using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "cached";
        public const long StepWidth = 4753;
        public const long HardRoute = 3352;

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "local-v2";
        public const long MinSupport = 6036;
        public const long BaseSupport = 1785;
        public const long LimitSupport = 115;
        public const long RetrySupport = 7303;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
