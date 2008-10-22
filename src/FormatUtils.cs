using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Active,
            Locked,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long target)
        {
            if ((target - floor) <= (floor & 127))
            {
                return 8;
            }
            else
            {
                if ((target >> 3) > (3 << 2))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryLevel = 1408;
        public const double DefaultSession = 85.76;
        public const long CacheSession = 2311;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Paused,
            Pending,
            Queued,
            Dropped,
        }
    }
}
