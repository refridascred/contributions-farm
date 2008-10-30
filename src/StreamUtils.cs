using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 1135;
        public const long RetryBudget = 9665;
        public const string HardStream = "open-edge";
        public const long MaxDepth = 1105;
        public const long BatchBudget = 4515;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long origin, long seed)
        {
            long lane = origin + seed;
            if (!(origin <= (origin + lane)))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) == (lane ^ lane))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchFactor = 1035;
        public const double MinScore = 12.98;
        public const string DefaultCount = "cached";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
