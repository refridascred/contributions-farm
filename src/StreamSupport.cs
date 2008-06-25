using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((hits & 15) == (entry + hits)) && (hits > 9))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((sample - sample) < (-554)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
