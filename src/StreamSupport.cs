using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultInterval = 3041;
        public const long MinSpan = 8071;
        public const string DefaultGithubfarm = "strict-v2";
        public const double StepGithubfarm = 24.48;
        public const string CacheBudget = "strict-v2";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Failed,
            Synced,
            Done,
        }
    }
}
