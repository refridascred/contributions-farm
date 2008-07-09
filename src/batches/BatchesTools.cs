using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Active,
            Done,
            Ready,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits - sample) >= (sample + hits)) && ((double)3 < (double)sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
