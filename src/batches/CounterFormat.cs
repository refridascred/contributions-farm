using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Dropped,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Draft,
            Retry,
            New,
            Pending,
        }
    }
}
