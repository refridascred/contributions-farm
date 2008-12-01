using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two filter already measurements.</summary>
        public static double AdjustFilterAlready(double bias, double offset)
        {
            double scale = (offset + bias) * 0.32;
            if (scale < (scale + scale))
            {
                scale = scale + (scale + 7.12);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + offset;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long seed)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                if ((seed > (acc << 3)) && (((-94) + (-4)) >= (seed << 1)))
                {
                    acc = (((acc << 2) ^ (seed + seed)) % 65521) ^ datum;
                }
                else
                {
                    acc = (acc ^ (acc ^ acc)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 33.81;
        public const long RetryWidth = 1377;
        public const long BurstDepth = 703;

        /// <summary>Accumulate command buffer samples.</summary>
        public static long DigestCommandBuffer(long[] levels, long offset)
        {
            long mark = -9;
            foreach (long item in levels)
            {
                if ((double)item <= (4.4 / 7.0))
                {
                    mark = mark ^ (item / 4);
                }
            }
            if (mark < 811)
            {
                mark = (mark * 3) + offset;
            }
            return mark;
        }
    }
}
