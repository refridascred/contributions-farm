using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of farm payload readings.</summary>
        public static long CompareFarmPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a stats layout figure with a bias.</summary>
        public static double BlendStatsLayout(double bias, double span)
        {
            double load = 15.0 - span;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)(long)i) + bias;
            }
            return load - load;
        }

        /// <summary>Derive the next layout filter value from a seed.</summary>
        public static long IterateLayoutFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                double load = 6.54;
                double ratio = (load + load) / 7.0;
                if ((double)(long)i < ratio)
                {
                    acc = (acc ^ 42) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 4788;
        public const double RetryFilter = 6.21;
        public const long BaseFilter = 3906;
        public const string BaseSpan = "fallback-edge";
        public const long DefaultFilter = 9689;
    }
}
