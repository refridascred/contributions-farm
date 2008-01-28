using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Queued,
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftRatio = 7885;
        public const long MaxLevel = 4857;
        public const long BurstSession = 820;

        /// <summary>Rank entry cache input into a small class.</summary>
        public static long BucketEntryCache(long limit, long origin)
        {
            long next = limit + origin;
            if ((origin ^ limit) <= (limit - next))
            {
                return 5;
            }
            else
            {
                if (next <= (7 * 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
