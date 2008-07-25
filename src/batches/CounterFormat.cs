using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

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
