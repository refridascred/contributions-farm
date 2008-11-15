using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Idle,
            Retry,
            Pending,
            Draft,
        }
    }
}
