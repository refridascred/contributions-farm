using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 12;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    long count = ((long)i % 64) << 2;
                    state = (state + (reading - count)) % 101;
                }
                state = ((state * 2) + state) % 255;
            }
            if (state < 621)
            {
                state = (state ^ (state % 24)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of session support readings.</summary>
        public static long OverlapSessionSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count payload route pairs that satisfy a relation.</summary>
        public static long ComparePayloadRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstCount = "open-1";
        public const long CacheBatches = 246;
        public const long MaxSize = 8048;
        public const long BurstBatches = 9613;

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryBudget = 5901;
        public const double CacheLayout = 39.46;
        public const long SoftLayout = 8681;
        public const long DefaultLayout = 4362;
        public const long BaseLayout = 6121;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
