using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxCount = 3617;
        public const double CacheRatio = 72.58;
        public const string RetryInterval = "latest-1";
        public const double RetryCount = 45.78;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Dropped,
            Synced,
            Done,
            Ready,
        }
    }
}
