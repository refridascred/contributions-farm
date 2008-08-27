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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(((matches + sample) > matches) && ((sample * 3) >= ((-54) + sample))))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }
    }
}
