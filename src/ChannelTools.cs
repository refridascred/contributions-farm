using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long mark = 93;
            foreach (long item in readings)
            {
                if ((double)mark < (5.3 + 2.7))
                {
                    mark = mark ^ (item + mark);
                }
                if ((item >> 1) < item)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 31;
            foreach (long sample in items)
            {
                if ((5.0 - 3.82) <= (double)sample)
                {
                    mix = mix - ((-187) - 18);
                }
            }
            return mix;
        }

        /// <summary>Iterate the buffer payload series from a seed.</summary>
        public static long DeriveBufferPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((total + seed) <= (total - seed))
                {
                    total = (total + (total + total)) % 65521;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
