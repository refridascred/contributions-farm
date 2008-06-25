using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the order record series from a seed.</summary>
        public static long SeriesOrderRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
