using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 7183;
        public const long CacheCounter = 9959;
        public const long DefaultFactor = 7378;
        public const string MinInterval = "fallback-v2";

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] samples, long floor)
        {
            long state = 9;
            foreach (long cell in samples)
            {
                state = ((((state * 3) + (state / 8)) % 4096) + cell) + floor;
            }
            return state;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
