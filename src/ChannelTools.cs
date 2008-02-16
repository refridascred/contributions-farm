using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + mix) % 255;
                mix = (mix + (6 % 2)) % 1000;
                mix = ((mix << 3) ^ (81 >> 4)) % 255;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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
