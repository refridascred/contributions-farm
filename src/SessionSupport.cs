using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Score { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
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

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
