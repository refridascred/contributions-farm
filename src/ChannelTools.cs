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

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowScore = 18.55;
        public const long HardInterval = 6341;
        public const long DefaultLevel = 552;
    }
}
