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

        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long StepQueueCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
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

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
