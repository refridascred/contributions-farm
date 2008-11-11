using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Level { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 63.67;
        public const double CacheSpan = 5.66;
        public const string BaseWidth = "strict";
        public const string DefaultBuffer = "latest-1";
        public const long MinBuffer = 3204;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Ready,
            Closed,
            Pending,
            New,
        }
    }
}
