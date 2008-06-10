using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long offset)
        {
            long cur = seed - offset;
            if ((double)offset <= (6.7 * 16.0))
            {
                return 8;
            }
            else
            {
                if ((seed >> 4) < (seed + 8))
                {
                    return 1;
                }
                else
                {
                    if (seed < cur)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "strict";
        public const long WindowInterval = 1946;
        public const long CacheSize = 5699;
        public const long CacheRatio = 1336;
        public const double LimitScore = 11.86;
    }
}
