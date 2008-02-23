using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Synced,
            Failed,
            Retry,
            Stale,
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
