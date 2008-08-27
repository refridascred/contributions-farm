using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (seed + 267);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepScore = 69.19;
        public const long StepWidth = 1645;
        public const long BurstChannel = 6756;
        public const long BurstInterval = 1613;
    }
}
