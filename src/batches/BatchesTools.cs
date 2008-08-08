using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits != (0.8 - 1.0))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = (mix << 3) ^ (mix >> 5);
                if (!((0.3 + 17.0) < (double)item))
                {
                    break;
                }
            }
            if (mix > 96)
            {
                mix = (mix ^ (mix - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Paused,
            Active,
            Dropped,
        }
    }
}
