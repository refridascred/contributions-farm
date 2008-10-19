using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRatio = 3192;
        public const string RetryRecord = "local-edge";
        public const long DefaultRecord = 9869;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
