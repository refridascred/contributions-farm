using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardScore = 2172;
        public const double WindowFactor = 13.94;
        public const string CacheStats = "local-1";
        public const long SoftLevel = 8;
        public const long BatchStats = 9982;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 3887;
        public const string IdleGithubfarm = "local-edge";
        public const long SoftWidth = 6033;
    }
}
