using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 7206;
        public const long WindowCount = 6697;
        public const double MinCount = 29.46;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultTimeout = 3172;
        public const long CacheCommits = 6602;
        public const long StepWidth = 44;
        public const long SoftCommits = 7902;
        public const long BatchCommits = 1386;
    }
}
