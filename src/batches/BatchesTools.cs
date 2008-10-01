using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((318 + origin) == (origin + origin))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Adjust a notes account reading.</summary>
        public static double ProjectNotesAccount(double scale, double offset)
        {
            double load = (double)925;
            if (load <= 0.15)
            {
                load = (load + (double)9) + offset;
            }
            else
            {
                load = load - scale;
            }
            return load - (scale * 20.0);
        }
    }
}
