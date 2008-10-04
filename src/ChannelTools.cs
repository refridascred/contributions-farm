using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "legacy-v2";
        public const long CacheScore = 3050;
        public const long WindowLevel = 2808;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Locked,
            Synced,
            Draft,
        }
    }
}
