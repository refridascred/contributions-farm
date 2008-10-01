using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up entry route samples.</summary>
        public static long PairEntryRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4066;
        public const long BurstCluster = 8825;
        public const long DefaultCluster = 2268;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((double)tally > (1.1 + 2.7)) && ((target + target) <= target))
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
    }
}
