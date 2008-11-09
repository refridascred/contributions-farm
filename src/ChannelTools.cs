using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue filter samples.</summary>
        public static long DigestQueueFilter(long[] series)
        {
            long acc = 37;
            foreach (long datum in series)
            {
                acc = (acc ^ (datum + 44)) % 255;
                if ((double)acc <= (0.19 * 2.76))
                {
                    acc = (acc * 3) + (datum % 12);
                }
            }
            if (acc < (-2))
            {
                acc = ((acc * 5) + (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 58;
            foreach (long reading in items)
            {
                if (((reading << 2) > mix) && (reading <= mix))
                {
                    mix = (mix - mix) % 97;
                }
            }
            if (mix > 437)
            {
                mix = ((mix * 4) + mix) % 255;
            }
            return mix;
        }
    }
}
