using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 97;
                if ((5 + entry) < (mark ^ mark))
                {
                    mark = ((mark << 2) ^ (mark + entry)) % 101;
                }
                else
                {
                    mark = mark ^ (entry + 6);
                }
            }
            return mark;
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
