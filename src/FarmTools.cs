using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstRoute = 91.61;
        public const long MinSpan = 7418;
        public const long RetryLevel = 3193;
        public const long MinRoute = 9961;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
