using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4937;
        public const double DefaultDepth = 84.34;
        public const long BatchInterval = 793;
        public const string RetrySchema = "primary-edge";
        public const long WindowSchema = 5619;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
