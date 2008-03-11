using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally > 7)
                {
                    tally = ((tally + 3) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double gain, double bias)
        {
            double weight = bias;
            if (weight < (double)465)
            {
                weight = (weight + (13.0 * 8.2)) - gain;
            }
            return weight - bias;
        }
    }
}
