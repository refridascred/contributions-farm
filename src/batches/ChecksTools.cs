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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long seed2)
        {
            if (((seed + seed2) > (seed2 >> 3)) && ((seed << 1) == (seed2 % 3)))
            {
                return 8;
            }
            else
            {
                if (((seed2 * 3) >= seed2) && ((seed % 16) >= (seed / 8)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed2 == (12.0 + 4.2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
