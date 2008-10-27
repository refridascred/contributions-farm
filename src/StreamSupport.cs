using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Active,
            Synced,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long seed, long limit)
        {
            long offset = seed - limit;
            if (((offset - offset) < (offset << 3)) && (seed > (205 + 1)))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= 10.0)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4678;
        public const string DefaultBatches = "legacy-edge";
        public const long MinLevel = 5451;
        public const string DefaultInterval = "staging";
    }
}
