using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally < (3.8 + 3.38))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples, long target)
        {
            long state = 471;
            foreach (long value in samples)
            {
                if (!((double)target < (6.33 * 3.93)))
                {
                    state = (state + value) % 97;
                }
                if ((20.0 + 3.4) < (double)target)
                {
                    state = (state + (state - target)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((double)hits <= (double)0))
                {
                    hits = ((hits + 2) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Synced,
            Active,
            Paused,
        }
    }
}
