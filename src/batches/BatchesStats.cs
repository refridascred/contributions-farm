using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 3) <= (entry % 97))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches <= (reading & 31))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long DigestGithubfarmFormat(long[] items)
        {
            long anchor = 28;
            foreach (long sample in items)
            {
                if ((7.2 * 4.52) >= (double)sample)
                {
                    anchor = ((anchor << 3) ^ (sample << 3)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
