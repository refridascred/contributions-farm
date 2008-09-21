using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 9249;
        public const long RetryQueue = 5756;
        public const long HardLevel = 6129;
        public const long MinDepth = 9072;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
