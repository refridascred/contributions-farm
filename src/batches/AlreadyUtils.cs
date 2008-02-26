using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9603;
        public const long BurstInterval = 8002;
        public const long BurstBatches = 8994;
        public const long DefaultBudget = 9913;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long seed2)
        {
            if ((seed2 ^ seed2) < 32)
            {
                return 7;
            }
            else
            {
                if ((seed2 / 2) > seed)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Failed,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev + limit) < (limit << 3))
            {
                return 2;
            }
            else
            {
                if (!((double)prev != (2.04 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 12) == (seed & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + limit) > 5)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
