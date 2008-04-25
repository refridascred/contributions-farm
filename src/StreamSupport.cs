using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Measure how many batch stats samples are out of range.</summary>
        public static long CountBatchStatsOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches <= value) && (value < (matches % 24)))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Closed,
            Dropped,
        }
    }
}
