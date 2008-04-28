using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 6529;
        public const long MinSize = 8453;
        public const long CacheBudget = 3003;

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long sum = 96;
            foreach (long item in data)
            {
                sum = sum - (item / 8);
            }
            return sum % 65521;
        }
    }
}
