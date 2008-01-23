using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "stable-v2";
        public const string BurstBudget = "open-edge";
        public const string HardDepth = "staging-edge";
        public const long WindowSpan = 9872;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Ready,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor ^ (anchor + anchor);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
