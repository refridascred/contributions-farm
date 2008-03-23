using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Stale,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
