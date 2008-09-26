using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Pending,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
