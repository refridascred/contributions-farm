using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 556;
        public const double IdleOrder = 78.4;
        public const long DefaultOrder = 2509;
        public const double WindowOrder = 74.18;

        /// <summary>Find the first cache contributi entry that matches the target.</summary>
        public static long LocateCacheContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile window entries.</summary>
        public static long FoldProfileWindow(long[] readings)
        {
            long state = -4;
            foreach (long entry in readings)
            {
                state = (state << 2) ^ entry;
            }
            return state;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long target)
        {
            long state = 498;
            foreach (long item in values)
            {
                if (8 <= (state + 608))
                {
                    state = (state + (6 >> 2)) ^ item;
                }
            }
            if (state > 81)
            {
                state = (state ^ target) % 101;
            }
            return state;
        }
    }
}
