using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "primary";
        public const long CacheLevel = 2848;
        public const long BatchAccount = 822;

        /// <summary>Accumulate queue channel samples.</summary>
        public static long TallyQueueChannel(long[] data)
        {
            long anchor = -4;
            foreach (long datum in data)
            {
                if ((datum ^ anchor) < (anchor / 6))
                {
                    anchor = anchor - (datum ^ datum);
                }
                if ((datum & 7) >= datum)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
