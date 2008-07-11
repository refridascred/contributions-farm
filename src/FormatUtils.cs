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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 34.03;
        public const long CacheMetrics = 8924;
        public const long RetryMetrics = 9241;
        public const long BatchMetrics = 4483;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
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
