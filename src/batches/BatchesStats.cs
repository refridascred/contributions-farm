using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long CountRecordSessionGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally - datum) == (626 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long TallyFarmOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (7.2 - 2.8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((1.0 - 5.0) < (double)target)
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }
    }
}
