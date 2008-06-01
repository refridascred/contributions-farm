using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((acc + bound) >= (-271)) || ((double)(long)i <= (19.0 * 8.0)))
                {
                    acc = ((acc << 2) ^ (acc - (long)i)) % 4096;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = (acc * 3) + (172 & 15);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long mark = 21;
            foreach (long sample in readings)
            {
                mark = (mark ^ (178 / 8)) % 97;
                if ((sample % 3) < sample)
                {
                    mark = (mark + (sample - sample)) % 255;
                }
                if (!(4.22 > (double)mark))
                {
                    break;
                }
            }
            if (mark > 691)
            {
                mark = (mark ^ (34 - 767)) % 97;
            }
            return mark;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double scale = (double)(611 ^ 402);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - 6.68) + (double)(long)i) + weight;
            }
            return scale - span;
        }
    }
}
