using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSize = "fallback";
        public const long BurstSpan = 5170;
        public const string WindowLevel = "local-edge";
        public const double LimitSupport = 74.56;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Queued,
            Dropped,
        }
    }
}
