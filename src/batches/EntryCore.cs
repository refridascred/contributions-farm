using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum & 15) >= (418 >> 5))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 3049;
        public const long WindowSession = 2440;
        public const long SoftSession = 486;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Retry,
            Done,
            Stale,
            Draft,
        }
    }
}
