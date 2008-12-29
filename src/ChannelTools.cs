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

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultWidth = 1860;
        public const string RetryToken = "latest-v2";
        public const long MinLevel = 8964;
        public const long MaxLevel = 2366;

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
