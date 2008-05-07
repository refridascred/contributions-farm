using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data, long limit)
        {
            long mix = 5;
            foreach (long reading in data)
            {
                mix = (((mix - (mix & 7)) % 65521) ^ reading) - limit;
            }
            return mix % 65521;
        }
    }
}
