using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                long hits = ((-22) * 2) << 3;
                score = (score ^ hits) % 4096;
                if (1.68 > (double)score)
                {
                    hits = ((hits * 4) + offset) % 101;
                    hits = hits ^ (score % 2);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((tally * 4) < cell) || ((10.0 - 1.0) != (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the account cache entries that pass the check.</summary>
        public static long AuditAccountCacheHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((0.8 + 2.1) <= (double)matches) && !((double)matches > (7.2 + 1.6)))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length * 5) == (entry ^ seed)) || (entry >= (entry + entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
