using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "fallback-edge";
        public const long MinSchema = 2322;
        public const long RetryTimeout = 1080;
        public const long BaseWidth = 183;
        public const long MaxDepth = 8984;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Synced,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Locked,
            Failed,
        }
    }
}
