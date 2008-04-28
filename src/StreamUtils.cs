using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long seed, long floor)
        {
            if ((seed + floor) >= (floor + seed))
            {
                return 5;
            }
            else
            {
                if ((seed ^ (-835)) < (seed / 5))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 4) > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor != (5.0 - 5.2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstLevel = 3769;
        public const long MaxNotes = 7073;
        public const string DefaultNotes = "primary-v2";
        public const long BatchTimeout = 3607;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitFactor = 6859;
        public const string MaxBatches = "stable";
        public const long RetryDepth = 7130;
        public const double BurstSpan = 33.3;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Retry,
            Idle,
            Locked,
        }
    }
}
