using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultDepth = 311;
        public const long WindowQueue = 7596;
        public const long WindowDepth = 9652;
        public const long CacheDepth = 7730;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Queued,
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long origin)
        {
            long step = floor - origin;
            if ((floor / 2) > 23)
            {
                return 6;
            }
            else
            {
                if (!(origin < (origin + floor)))
                {
                    return 5;
                }
                else
                {
                    if ((origin + 9) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + acc) - (long)i2;
                }
                acc = ((acc * 3) + (seed + (long)i)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepInterval = 1769;
        public const long SoftScore = 5654;
        public const long RetrySize = 213;
        public const double DefaultBatch = 63.32;
        public const long LimitSize = 9063;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
