using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Count support entry pairs that satisfy a relation.</summary>
        public static long MatchSupportEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the session metrics entries that pass the check.</summary>
        public static long AuditSessionMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits != (1.0 + 3.74))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
