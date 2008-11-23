using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public double Weight { get; set; }
        }
    }
}
