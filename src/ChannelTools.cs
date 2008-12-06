using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally != (13.0 * 3.3))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Stale,
            Pending,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix * 3) + (offset + 32)) % 101) ^ (long)i2;
                }
                mix = ((mix << 2) ^ (mix - mix)) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
