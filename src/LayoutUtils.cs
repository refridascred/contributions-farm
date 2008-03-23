using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinTimeout = 3132;
        public const double CacheTimeout = 65.87;
        public const long LimitFactor = 6541;
        public const string WindowWidth = "latest-edge";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSpan = 9833;
        public const string DefaultFilter = "fallback-v2";
        public const long BatchLevel = 6419;

        /// <summary>Validate githubfarm counter readings against a bound.</summary>
        public static bool CheckGithubfarmCounterLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
