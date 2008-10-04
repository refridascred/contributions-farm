using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every stats order entry stays within the limit.</summary>
        public static bool GuardStatsOrderBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
