using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)(long)series.Length > 4.0) && !((seed - seen) <= seed))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(item <= (item / 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
