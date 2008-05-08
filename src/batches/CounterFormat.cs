using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Queued,
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Count the buffer batch entries that pass the check.</summary>
        public static long TallyBufferBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((double)sample < (12.0 - 3.6)) && ((1.98 - 2.22) < (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
