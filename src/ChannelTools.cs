using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (9.71 * 16.0))
                {
                    count = count + 1;
                }
            }
            return count;
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
