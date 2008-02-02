using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Ready,
            Active,
            Done,
            Synced,
        }
    }
}
