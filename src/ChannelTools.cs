using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((4.7 / 2.0) == (double)target))
                {
                    state = (state - (state + state)) % 101;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data)
        {
            long mark = -4;
            foreach (long item in data)
            {
                mark = mark ^ (mark % 12);
                if (((mark & 15) == (mark - mark)) && ((920 - 29) > item))
                {
                    mark = mark ^ (mark % 2);
                }
                if ((item + item) < (mark + item))
                {
                    break;
                }
            }
            if (mark < 73)
            {
                mark = (mark ^ (mark >> 5)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double bias = (double)(3 % 24);
            if (bias < span)
            {
                bias = (bias + 6.8) + rate;
            }
            else
            {
                bias = bias + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (8.7 / 4.0)) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
