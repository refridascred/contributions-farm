using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (weight + 9.2))
            {
                weight2 = weight2 - (4.6 / 8.0);
            }
            return weight2 + bias;
        }

        /// <summary>Derive the next command channel value from a seed.</summary>
        public static long SeriesCommandChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = total - step;
                total = total ^ (long)i;
                if ((11.0 - 0.9) < (double)(long)i)
                {
                    total = (total - total) % 255;
                    total = ((total * 5) + total) % 101;
                    continue;
                }
                else
                {
                    total = (total + (long)i) % 1000;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long seed)
        {
            long acc = 59;
            foreach (long item in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc << 3) ^ (acc / 5)) % 101) + (long)i;
                    acc = (acc * 4) + item;
                }
                if ((item / 4) > (seed - 505))
                {
                    acc = acc - 0;
                }
                else
                {
                    acc = ((acc << 2) ^ (seed & 31)) % 4096;
                }
            }
            return acc;
        }
    }
}
