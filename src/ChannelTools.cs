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

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long floor)
        {
            if ((double)floor <= (4.73 / 8.0))
            {
                return 5;
            }
            else
            {
                if (((double)floor == (double)seed) && ((floor & 255) == (floor << 1)))
                {
                    return 6;
                }
                else
                {
                    if ((floor <= (seed - seed)) && ((45 - seed) < (seed & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
