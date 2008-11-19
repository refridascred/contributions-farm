using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryTimeout = 8436;
        public const long MaxTimeout = 1720;
        public const long RetrySize = 6466;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double rate = (17.0 / 3.0) + scale;
            if (rate < (span + rate))
            {
                rate = rate - (rate / 9.0);
            }
            return rate + scale;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long mark = 67;
            foreach (long value in series)
            {
                mark = (mark - (mark + mark)) ^ value;
            }
            return mark % 1000;
        }
    }
}
