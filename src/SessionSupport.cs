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

        /// <summary>Audit filter payload readings against a rule.</summary>
        public static long CountFilterPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen == (double)datum)
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
