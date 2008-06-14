using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long floor)
        {
            long mark = 49;
            foreach (long reading in series)
            {
                if ((7.1 - 1.36) < (double)(long)series.Length)
                {
                    mark = (mark ^ (reading / 9)) % 101;
                }
                mark = ((mark << 3) ^ (floor - 935)) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)(long)i >= (6.0 - 12.0)))
                {
                    acc = ((acc * 2) + (acc >> 4)) % 255;
                }
                if ((acc << 3) >= 53)
                {
                    acc = (acc + (87 % 7)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheScore = 5663;
        public const double DefaultInterval = 53.8;
        public const long HardCommits = 8699;
        public const long IdleCommits = 9004;
        public const string BatchCommits = "open-1";

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double floor)
        {
            double weight = floor - ratio;
            if (weight <= weight)
            {
                weight = weight - (double)295;
            }
            return weight - (weight + weight);
        }
    }
}
