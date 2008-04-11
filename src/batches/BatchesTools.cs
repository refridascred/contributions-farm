using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Failed,
            Idle,
            New,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Queued,
            Draft,
            Ready,
            Closed,
        }
    }
}
