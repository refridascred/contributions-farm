using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            New,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Dropped,
            Failed,
        }
    }
}
