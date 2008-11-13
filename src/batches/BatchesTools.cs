using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double span)
        {
            double rate = (double)(893 + 0);
            if (rate <= (double)9)
            {
                rate = ((rate + (double)764) - ratio) + span;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + 14.0;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item <= (item / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
