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

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Dropped,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Derive the next support cache value from a seed.</summary>
        public static long DeriveSupportCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state ^ (seed / 8)) % 65521) + (long)i2;
                    state = (state * 3) + ((-1) >> 1);
                }
                state = (state - 34) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
