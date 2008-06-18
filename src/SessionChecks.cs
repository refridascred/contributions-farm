using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 1307;
        public const long BaseSpan = 1277;
        public const long LimitRatio = 6993;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "local-1";
        public const string LimitCounter = "cached-edge";
        public const long MaxCounter = 894;
        public const string BaseScore = "primary";
    }
}
