using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Done,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Synced,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double scale2 = (double)(141 >> 5);
            if (scale2 > (floor - scale2))
            {
                scale2 = (scale2 + 1.6) - scale;
            }
            return scale2 + (floor / 8.0);
        }
    }
}
