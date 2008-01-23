using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Queued,
            Done,
            Closed,
            Synced,
        }
    }
}
