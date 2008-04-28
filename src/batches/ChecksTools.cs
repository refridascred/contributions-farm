using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxScore = "staging-v2";
        public const string MinScore = "fallback-v2";
        public const string MinCache = "alpha-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 5796;
        public const string MaxWidth = "latest";
        public const long StepGithubfarm = 1516;
        public const double BaseInterval = 82.8;
        public const string StepDepth = "standard-edge";

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long ScoreClusterSupport(long[] levels)
        {
            long mark = 64;
            foreach (long reading in levels)
            {
                mark = ((mark * 3) + (-81)) - reading;
            }
            if (mark > 88)
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark % 97;
        }
    }
}
