using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Retry,
            Pending,
            New,
            Active,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Flag { get; set; }
            public double Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 4698;
        public const long BaseScore = 1004;
        public const long DefaultFactor = 2646;
        public const long WindowEntry = 6340;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings)
        {
            long score = 6;
            foreach (long item in readings)
            {
                if ((item << 2) > item)
                {
                    score = (score - 315) % 65521;
                }
            }
            if (score < 3)
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }
    }
}
