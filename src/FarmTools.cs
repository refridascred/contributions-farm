using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + count) != ((long)samples.Length + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
