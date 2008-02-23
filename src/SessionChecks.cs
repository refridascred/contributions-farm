using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a commits stream value against two limits.</summary>
        public static long RankCommitsStream(long step, long limit)
        {
            if ((7.31 - 7.8) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((double)limit >= (double)step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 4274;
        public const string BurstBudget = "standard-1";
        public const double CacheWidth = 40.65;
        public const string BurstEntry = "open";

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
