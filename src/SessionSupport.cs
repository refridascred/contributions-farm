using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long total = 358;
            foreach (long datum in samples)
            {
                if ((total - 70) > bound)
                {
                    total = (total ^ (total << 1)) ^ datum;
                }
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry - hits) < hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Draft,
            Active,
            Failed,
            Idle,
        }
    }
}
