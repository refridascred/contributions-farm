using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (1.0 > (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batches filter readings against a rule.</summary>
        public static long TallyBatchesFilterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry < (hits >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry ^ seen) < (entry * 2)) || ((66 + entry) < entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
