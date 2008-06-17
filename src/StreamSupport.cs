using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix + (mix + origin)) % 97) ^ (long)i2;
                }
                mix = mix ^ (mix << 3);
                if (8 > (mix >> 5))
                {
                    continue;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 97;
                    mix = (mix * 3) + ((-956) - mix);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next counter tools value.</summary>
        public static double AdjustCounterTools(double weight, double span)
        {
            double gain = (double)(364 / 3);
            if (gain <= span)
            {
                gain = (gain + gain) - weight;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + (span * 4.59);
        }
    }
}
