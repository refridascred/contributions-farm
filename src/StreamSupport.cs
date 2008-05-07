using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "latest-edge";
        public const string DefaultScore = "open-1";
        public const string HardGithubfarm = "cached";
        public const long CacheGithubfarm = 1756;

        /// <summary>Find the first githubfarm command entry that matches the target.</summary>
        public static long LookupGithubfarmCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
