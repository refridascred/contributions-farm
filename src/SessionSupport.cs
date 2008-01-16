using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Ready,
            New,
            Retry,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
