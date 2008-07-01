using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 6032;
        public const string BurstCounter = "latest-v2";
        public const string CacheInterval = "staging-edge";

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Dropped,
            New,
            Active,
        }
    }
}
