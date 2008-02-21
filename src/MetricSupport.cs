using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryScore = "cached";
        public const long MinFilter = 4379;
        public const long CacheFilter = 3146;
        public const long RetryFilter = 1621;
        public const long BaseSpan = 5132;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
        }
    }
}
