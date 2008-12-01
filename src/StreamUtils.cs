using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "latest-1";
        public const long MaxRecord = 5072;
        public const long SoftDepth = 7227;
        public const long BaseScore = 1594;
        public const long IdleWidth = 9012;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 6688;
        public const double CacheBatch = 68.91;
        public const long HardBatch = 8008;
        public const long WindowWidth = 4269;
        public const string BurstBatch = "staging-1";

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double weight = bias2 / 8.0;
            if (weight < weight)
            {
                weight = (weight + (double)411) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (bias2 + 9.7)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseBudget = 5915;
        public const string SoftWindow = "stable";
        public const double SoftFactor = 58.02;
        public const long BaseDepth = 7828;
    }
}
