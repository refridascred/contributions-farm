using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSize = 3350;
        public const double RetryScore = 87.49;
        public const long CacheSupport = 4361;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Active,
            Dropped,
            New,
        }
    }
}
