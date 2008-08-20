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

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 8642;
        public const double SoftSpan = 16.58;
        public const string BaseSize = "latest-v2";
        public const string IdleInterval = "latest-edge";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Synced,
            Done,
        }
    }
}
