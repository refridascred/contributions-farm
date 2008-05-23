using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 4636;
        public const double DefaultWidth = 61.33;
        public const double WindowDepth = 78.79;
        public const long RetryQueue = 7353;
        public const long SoftFactor = 9308;

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 43.58;
        public const long WindowSpan = 1527;
        public const long CacheScore = 1527;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
