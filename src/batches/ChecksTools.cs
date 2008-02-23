using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Dropped,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "legacy-edge";
        public const long BatchCount = 2729;
        public const long MaxSession = 7741;
        public const long CacheSession = 3708;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 5225;
        public const double CacheCount = 36.63;
        public const long WindowCommand = 9049;
        public const double IdleWidth = 48.74;
    }
}
