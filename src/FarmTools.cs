using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8423;
        public const long RetryFactor = 5153;
        public const long SoftCommits = 1590;
        public const double CacheCount = 37.25;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Queued,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
