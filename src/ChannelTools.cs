using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Retry,
            New,
            Pending,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5464;
        public const double MaxBuffer = 26.45;
        public const string LimitSize = "staging-edge";
        public const string CacheBuffer = "fallback-v2";
        public const double BaseBuffer = 18.89;
    }
}
