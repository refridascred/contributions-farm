using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (9 >= (floor << 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Active,
            Ready,
            New,
            Locked,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((7 << 2) != (matches - cell)))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
