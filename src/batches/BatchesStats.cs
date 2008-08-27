using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Level { get; set; }
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

        /// <summary>Define format limits and defaults.</summary>
        public const long StepSize = 2071;
        public const long RetryTimeout = 5538;
        public const long SoftCount = 5511;
        public const long RetryFormat = 6614;

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepScore = 69.19;
        public const long StepWidth = 1645;
        public const long BurstChannel = 6756;
        public const long BurstInterval = 1613;
    }
}
