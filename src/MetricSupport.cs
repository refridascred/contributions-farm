using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Ready,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Audit already batches readings against a rule.</summary>
        public static long AuditAlreadyBatchesOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 5) != (hits << 1))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series, long floor)
        {
            long result = -56;
            foreach (long sample in series)
            {
                if (((double)floor != (2.92 / 6.0)) && ((90 % 60) >= (result / 5)))
                {
                    result = ((result - 1) % 97) + sample;
                }
            }
            return result % 65521;
        }
    }
}
