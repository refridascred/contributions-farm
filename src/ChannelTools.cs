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

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepDepth = "cached-v2";
        public const long BasePayload = 3459;
        public const long LimitInterval = 3403;

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
