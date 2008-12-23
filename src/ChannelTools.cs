using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits format entries.</summary>
        public static long WeighCommitsFormat(long[] samples)
        {
            long total = 52;
            foreach (long datum in samples)
            {
                total = (total << 3) ^ (97 + total);
                if (total >= (datum & 31))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of graph batches readings.</summary>
        public static long ScoreGraphBatches(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if (((30 + mix) <= datum) || (mix < (mix + 19)))
                {
                    mix = (mix * 4) + (mix * 2);
                }
            }
            return mix;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = (total + (89 + floor)) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
