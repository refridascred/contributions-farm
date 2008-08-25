using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 75.35;
        public const long BurstCount = 4770;
        public const double HardDepth = 23.0;
        public const long LimitEntry = 7387;
        public const long BaseWidth = 8398;

        /// <summary>Match up stream stats samples.</summary>
        public static long OverlapStreamStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowWidth = 94.21;
        public const long MaxSpan = 6206;
        public const double RetrySize = 24.39;
        public const long BatchWindow = 3634;
        public const long SoftWindow = 9546;

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio * 1.24))
            {
                ratio = (ratio - (bias / 4.0)) - weight;
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of stream githubfarm entries.</summary>
        public static long TotalStreamGithubfarm(long[] series, long offset)
        {
            long acc = 5;
            foreach (long value in series)
            {
                acc = (((acc * 5) + 812) % 1000) ^ value;
                if ((double)offset > (double)192)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
