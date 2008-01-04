using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values)
        {
            long mark = 818;
            foreach (long sample in values)
            {
                if ((mark << 2) <= sample)
                {
                    mark = (mark << 2) ^ (mark ^ mark);
                }
                if ((sample >> 5) < 0)
                {
                    mark = mark ^ (sample & 15);
                }
                else
                {
                    mark = mark ^ (sample & 255);
                }
            }
            if (mark < 96)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 8718;
        public const long IdleGithubfarm = 5939;
        public const double HardLevel = 44.27;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double gain = (double)(591 + 99);
            if (gain < (bias + bias))
            {
                gain = (gain - gain) - scale;
            }
            else
            {
                gain = gain - 6.0;
            }
            return gain - (7.3 / 8.0);
        }
    }
}
