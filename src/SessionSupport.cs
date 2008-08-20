using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

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
