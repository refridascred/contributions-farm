using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Active,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2301;
        public const long StepCount = 884;
        public const long HardScore = 8602;
        public const long DefaultInterval = 7128;
        public const long RetryInterval = 9158;
    }
}
