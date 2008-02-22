using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)origin > (1.67 - 6.3))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit payload profile readings against a rule.</summary>
        public static long AuditPayloadProfileHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((5.0 * 7.1) >= (double)hits))
                {
                    hits = ((hits + 1) ^ cell) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstDepth = 3814;
        public const double LimitSpan = 91.62;
        public const long MaxLevel = 8224;
        public const string SoftChecks = "strict-1";
    }
}
