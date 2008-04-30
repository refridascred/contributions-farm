using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 6779;
        public const string CacheLevel = "legacy-v2";
        public const long BurstSize = 3057;
        public const long MaxSize = 9731;
        public const long CacheCount = 6133;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
