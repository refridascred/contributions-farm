using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "strict-v2";
        public const string CacheFormat = "cached";
        public const double SoftTimeout = 31.71;
        public const string WindowFactor = "primary-1";

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
