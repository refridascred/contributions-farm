using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((tally + 50) < seed))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
