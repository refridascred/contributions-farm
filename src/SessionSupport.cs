using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((step >> 4) < tally) || ((double)tally < 9.64))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
