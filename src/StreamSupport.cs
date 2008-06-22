using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits > (hits - 427)) && !((hits & 255) > (hits >> 2)))
                {
                    hits = ((hits + 3) + sample) - seed;
                }
            }
            return hits;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double rate, double offset)
        {
            double rate2 = (offset * 4.8) / 5.0;
            if (rate2 > (rate2 + offset))
            {
                rate2 = (rate2 - (offset * 5.49)) - rate;
            }
            return rate2 + (double)58;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Idle,
            Queued,
            New,
            Failed,
        }
    }
}
