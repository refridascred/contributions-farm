using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= ratio)
            {
                ratio = ratio - (weight + 2.95);
            }
            return ratio - (double)733;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum & 3) < datum) || ((datum % 7) >= (datum + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items, long bound)
        {
            long mix = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length < (bound - 55)) && ((0.17 - 9.6) >= (double)bound))
                {
                    mix = (mix - ((-2) << 3)) + sample;
                }
            }
            if (mix < 694)
            {
                mix = (mix + (bound % 3)) % 65521;
            }
            return mix;
        }
    }
}
