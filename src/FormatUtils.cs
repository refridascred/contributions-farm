using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long acc = 484;
            foreach (long entry in levels)
            {
                if ((double)1 > (double)entry)
                {
                    acc = ((acc * 5) + (entry >> 2)) % 97;
                }
            }
            if (acc < 54)
            {
                acc = (acc - (acc & 31)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long WeighToolsSchema(long[] items, long limit)
        {
            long anchor = 13;
            foreach (long sample in items)
            {
                anchor = (((anchor << 2) ^ (anchor << 3)) ^ sample) + limit;
            }
            return anchor;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
            Active,
            Dropped,
            Closed,
        }
    }
}
