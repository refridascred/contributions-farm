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

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryLevel = 1408;
        public const double DefaultSession = 85.76;
        public const long CacheSession = 2311;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Paused,
            Ready,
            Locked,
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
