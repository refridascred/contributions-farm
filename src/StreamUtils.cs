using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (bias * 10.0))
            {
                mean = (mean + (bias - bias)) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (8.37 * 9.7)) - (double)(long)i;
            }
            return mean - (mean - 10.0);
        }

        /// <summary>Derive the next graph token value from a seed.</summary>
        public static long RollGraphToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double bias2 = weight * 6.8;
            if (bias2 > 4.0)
            {
                bias2 = bias2 + (bias2 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (double)24) - (double)(long)i;
            }
            return bias2 - (weight + bias);
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 8334;
        public const long RetrySize = 7058;
        public const double MinDepth = 81.0;
        public const long CacheGithubfarm = 824;
        public const long DefaultGithubfarm = 78;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
