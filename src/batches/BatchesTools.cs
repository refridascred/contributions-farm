using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long AuditBatchesEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches >= (1.7 - 11.0))
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches counter value from a seed.</summary>
        public static long SeriesBatchesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if (6.4 > (double)bound)
                {
                    score = (score * 4) + 86;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = (mix ^ sample) % 255;
            }
            return mix % 4096;
        }
    }
}
