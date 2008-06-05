using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio > weight)
            {
                ratio = (ratio + (double)1) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 4.4) + (double)(long)i;
            }
            return ratio - (weight * 0.61);
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items)
        {
            long mix = 8;
            foreach (long reading in items)
            {
                if ((0.42 / 8.0) >= (double)reading)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            if (mix > (-10))
            {
                mix = mix + ((-403) % 60);
            }
            return mix;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
