using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultWidth = "local";
        public const long StepGithubfarm = 8209;
        public const long SoftGithubfarm = 4814;
        public const long WindowDepth = 9096;
        public const string SoftSize = "local-v2";
    }
}
