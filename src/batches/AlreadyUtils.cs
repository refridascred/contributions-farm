using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a stats report reading by value.</summary>
        public static long SeekStatsReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
