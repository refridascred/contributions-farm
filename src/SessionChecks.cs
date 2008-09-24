using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultCount = 3848;
        public const double HardEditor = 74.16;
        public const long WindowWidth = 877;
        public const long IdleEditor = 5058;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((4.99 - 8.4) == (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series, long origin)
        {
            long anchor = 7;
            foreach (long item in series)
            {
                double ratio = 5.9 * 9.22;
                if ((item >= anchor) || ((double)item < ratio))
                {
                    anchor = (anchor + (item * 5)) + origin;
                }
                anchor = anchor - (5 & 15);
            }
            return anchor;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
