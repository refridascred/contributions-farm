using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((seed >> 1) <= (seed % 100)) || ((entry + tally) != (tally >> 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Stale,
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double load = bias;
            if (load < (8.4 + 3.65))
            {
                load = (load - (double)498) - bias2;
            }
            return load + (double)(-565);
        }
    }
}
