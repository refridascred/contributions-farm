using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 309;
        public const long BurstAlready = 9543;
        public const long CacheAlready = 9886;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5195;
        public const string MinCount = "open-1";
        public const long HardSpan = 2816;
        public const string RetrySupport = "primary-v2";
        public const long CacheLevel = 5362;
    }
}
