using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            New,
            Idle,
            Done,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Draft,
            Ready,
            Queued,
        }
    }
}
