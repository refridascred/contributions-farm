using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Done,
            Retry,
            New,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] data)
        {
            long sum = 943;
            foreach (long reading in data)
            {
                if ((double)sum >= (11.0 - 16.0))
                {
                    sum = (sum - (reading / 2)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 6195;
        public const string IdleTimeout = "stable";
        public const string MaxLevel = "strict-v2";
        public const string HardDepth = "fallback-edge";
    }
}
