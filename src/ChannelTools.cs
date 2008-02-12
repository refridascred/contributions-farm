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

        /// <summary>Project the next cluster stats value.</summary>
        public static double ScaleClusterStats(double rate, double span)
        {
            double scale = (double)7 * 16.0;
            if (scale < 8.58)
            {
                scale = (scale - (double)16) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (span + span)) - (double)(long)i;
            }
            return scale - 7.27;
        }
    }
}
