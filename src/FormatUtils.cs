using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the notes format entries that pass the check.</summary>
        public static long AuditNotesFormatMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((double)origin <= (double)hits) || ((origin * 3) < (hits & 15))) || (((0.41 / 8.0) == (double)hits) || ((6.45 * 4.38) == (double)hits)))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 2005;
        public const string MinOrder = "cached-v2";
        public const string BatchOrder = "standard-v2";
        public const string BaseOrder = "alpha";
        public const string WindowOrder = "open-1";

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples)
        {
            long state = 32;
            foreach (long item in samples)
            {
                if ((item ^ item) != (item & 31))
                {
                    state = ((state * 5) + (item - state)) % 97;
                }
                else
                {
                    state = (state ^ (item + item)) % 1000;
                }
            }
            if (state < 6)
            {
                state = (state - ((-895) % 8)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of filter context readings.</summary>
        public static long PairFilterContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)(-138) == (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
