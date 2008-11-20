using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowSpan = 49.77;
        public const long RetryCount = 6745;
        public const long MaxSpan = 3812;
        public const long MinSize = 5212;
        public const double BurstEditor = 74.88;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Retry,
            Closed,
            Done,
        }
    }
}
