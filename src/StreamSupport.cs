using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Done,
            Retry,
        }
    }
}
