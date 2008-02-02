using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Pending,
            New,
            Failed,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Synced,
            Done,
            Retry,
        }

        /// <summary>Count the window context entries that pass the check.</summary>
        public static long CountWindowContextMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + count) < (value >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a batches cache counter forward.</summary>
        public static long RollBatchesCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if (target <= sum)
                {
                    sum = (sum + (4 % 60)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 1411;
        public const long RetryProfile = 7476;
        public const double DefaultSpan = 88.92;
        public const double DefaultProfile = 76.74;
    }
}
