using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }
    }
}
