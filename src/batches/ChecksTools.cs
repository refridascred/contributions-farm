using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinScore = 9335;
        public const long HardCommits = 2017;
        public const string DefaultFactor = "legacy-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 28.97;
        public const double IdleCluster = 41.13;
        public const string SoftCluster = "open";

        /// <summary>Define support limits and defaults.</summary>
        public const long MinWidth = 808;
        public const long StepDepth = 7822;
        public const long SoftSupport = 7260;
        public const long IdleSupport = 6886;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            New,
            Closed,
            Draft,
        }
    }
}
