using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long FoldStreamBuffer(long[] samples, long bound)
        {
            long score = 24;
            foreach (long datum in samples)
            {
                score = (((score * 3) + (score - score)) % 97) - bound;
                if ((score & 15) == (datum >> 5))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((9 >> 4) > ((long)i * 5))
                {
                    mix = ((mix * 2) + (bound ^ 870)) % 4096;
                    mix = (mix ^ ((long)i + bound)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
