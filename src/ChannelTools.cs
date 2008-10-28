using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftSpan = 90.52;
        public const string DefaultTimeout = "latest";
        public const long WindowOrder = 9090;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Active,
            Locked,
            Retry,
            Synced,
        }
    }
}
