using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Queued,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 6372;
        public const double BaseInterval = 47.02;
        public const long BatchSize = 8470;
        public const long IdleCounter = 7981;
        public const long BatchScore = 6853;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 88.91;
        public const long LimitMetrics = 5643;
        public const long BaseMetrics = 2605;
    }
}
