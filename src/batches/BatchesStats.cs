using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheTimeout = "alpha-v2";
        public const double DefaultRoute = 73.67;
        public const double HardRoute = 40.78;
        public const long BaseRoute = 9654;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Dropped,
            Synced,
            Ready,
            Locked,
        }
    }
}
