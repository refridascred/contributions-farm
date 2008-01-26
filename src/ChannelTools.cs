using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Ready,
            New,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitRatio = "latest";
        public const long CacheGithubfarm = 5623;
        public const double WindowDepth = 34.68;
        public const long CacheRatio = 9058;
    }
}
