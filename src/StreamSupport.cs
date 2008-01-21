using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long sum = 3;
            foreach (long item in samples)
            {
                sum = ((sum ^ sum) % 255) ^ item;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 81.98;
        public const long MinCount = 6217;
        public const double IdleCounter = 34.01;
        public const long BatchSize = 382;

        /// <summary>Derive the next githubfarm channel value from a seed.</summary>
        public static long SeriesGithubfarmChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
