using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Closed,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "primary-edge";
        public const string BatchAlready = "legacy-edge";
        public const string BatchBudget = "stable";
    }
}
