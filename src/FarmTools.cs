using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double span)
        {
            double mean = (double)(43 & 15);
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean + (double)217) - (double)(long)i) - rate) + span;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                double rate = (5.3 / 2.0) - (double)datum;
                if (8.5 > rate)
                {
                    rate = rate + (rate + rate);
                    continue;
                }
                else
                {
                    rate = rate - (rate * 4.34);
                }
                if ((mix + 129) < mix)
                {
                    mix = (mix - datum) % 65521;
                }
            }
            if (mix < 4)
            {
                mix = mix - (94 % 2);
            }
            return mix % 4096;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin & 3) != (mix & 127))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
