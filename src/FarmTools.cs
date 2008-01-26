using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long seed, long floor)
        {
            long gap = seed + floor;
            if (((1.3 * 6.0) <= (double)gap) && (38 >= (858 + seed)))
            {
                return 3;
            }
            else
            {
                if (3.23 >= (6.61 - 2.7))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            New,
            Queued,
            Idle,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Failed,
            Locked,
            Stale,
        }
    }
}
