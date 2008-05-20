using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
            public bool Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 49.51;
        public const long CacheCounter = 251;
        public const long BatchScore = 8580;
    }
}
