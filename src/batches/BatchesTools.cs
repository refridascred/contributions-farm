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

        /// <summary>Blend two editor metrics measurements.</summary>
        public static double SmoothEditorMetrics(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + 3.4) + (double)(long)i) - rate;
            }
            return load - (offset / 6.0);
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Dropped,
            Ready,
        }
    }
}
