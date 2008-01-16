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

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 3783;
        public const long BurstSession = 6161;
        public const string WindowCount = "standard-1";

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
