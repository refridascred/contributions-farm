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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Stale,
            Draft,
            Ready,
            Idle,
        }

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
