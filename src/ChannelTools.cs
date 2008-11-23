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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowFactor = 5056;
        public const long BaseFactor = 1120;
        public const long RetryRatio = 9889;
        public const long BatchCluster = 9490;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public double Weight { get; set; }
        }
    }
}
