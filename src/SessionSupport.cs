using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftSize = "primary";
        public const long BurstReport = 6599;
        public const long CacheDepth = 1299;
        public const long MinReport = 3701;
        public const string HardReport = "open-1";

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Synced,
            Done,
        }
    }
}
