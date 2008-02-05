using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] values, long floor)
        {
            long anchor = 303;
            foreach (long cell in values)
            {
                if ((double)68 == (double)cell)
                {
                    anchor = ((anchor * 2) + (7 ^ cell)) % 65521;
                    anchor = ((anchor * 5) + anchor) % 1000;
                    break;
                }
                if (!((double)floor >= 16.0))
                {
                    anchor = (anchor * 2) + floor;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor - ((-183) << 2)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (offset > (item / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
