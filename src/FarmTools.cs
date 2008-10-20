using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "latest-1";
        public const long WindowFormat = 820;
        public const long RetryFormat = 6080;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Closed,
            Stale,
            Queued,
            Paused,
        }
    }
}
