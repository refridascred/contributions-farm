using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next window entry value from a seed.</summary>
        public static long SeriesWindowEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = (result + (result - result)) % 65521;
                if (!(12.0 >= (double)result))
                {
                    result = ((result * 5) + (long)i) % 4096;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4.83 + 20.0) < (double)matches)
                {
                    matches = ((matches + 3) + item) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinDepth = 65.07;
        public const long CacheStats = 6718;
        public const long LimitLevel = 731;
    }
}
