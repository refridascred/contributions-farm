using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if (mix >= 3)
                {
                    mix = mix + (origin << 1);
                }
                if ((9 & 7) >= (mix - (long)i))
                {
                    mix = mix + (mix + mix);
                    mix = (mix << 2) ^ origin;
                }
                else
                {
                    mix = (mix + (mix >> 3)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double gain = scale;
            if (gain > (9.8 - gain))
            {
                gain = (gain + (double)2) - bias;
            }
            return gain - (double)56;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if ((acc << 3) < sample)
                {
                    acc = (acc ^ (sample + acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
