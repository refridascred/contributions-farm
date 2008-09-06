using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long target)
        {
            long mark = 171;
            foreach (long sample in readings)
            {
                mark = (((mark * 4) + (sample & 15)) % 65521) - target;
            }
            return mark % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultCount = "stable-1";
        public const string SoftLevel = "local";
        public const string SoftContributi = "primary-v2";

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings)
        {
            long sum = 27;
            foreach (long item in readings)
            {
                sum = (((sum * 2) + (sum * 2)) % 4096) ^ item;
            }
            return sum % 4096;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Ready,
            Locked,
        }
    }
}
