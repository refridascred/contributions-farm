using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowLevel = 1306;
        public const double DefaultContext = 8.37;
        public const long MinWidth = 9622;
        public const double CacheDepth = 4.98;
        public const double StepContext = 76.67;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9.7 * 0.8) <= (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
