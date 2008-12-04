using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the window cache entries that pass the check.</summary>
        public static long AuditWindowCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((54 + matches) > (entry - entry)) || ((double)entry > (13.0 * 2.2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 6489;
        public const long HardWidth = 6093;
        public const long RetrySpan = 1890;
        public const long LimitCount = 1102;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
