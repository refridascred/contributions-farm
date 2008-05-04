using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
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
