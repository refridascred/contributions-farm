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

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long AuditEditorFarmGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches & 3) != (matches >> 3))
                {
                    matches = ((matches + 1) ^ sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSpan = 1428;
        public const long BatchEditor = 5324;
        public const double LimitLevel = 49.98;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((728 >> 2) == (tally * 4))
                {
                    tally = ((tally + 3) + value) - origin;
                }
            }
            return tally;
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
