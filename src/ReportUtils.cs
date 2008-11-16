using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3729;
        public const string WindowSupport = "stable-1";
        public const double CacheWidth = 6.49;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(((cell + seen) > (cell << 1)) && ((10.0 - 3.6) == (double)cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Paused,
            Dropped,
            Active,
            Synced,
        }
    }
}
