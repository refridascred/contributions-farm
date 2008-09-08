using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((8.7 + 19.0) < (double)hits) && (hits <= (11 - hits))) || ((0.89 / 9.0) < (double)hits))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxScore = 36.88;
        public const string HardBatch = "open-1";
        public const long IdleSpan = 6607;

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (5.0 - 16.0))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
