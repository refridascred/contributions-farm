using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultScore = 2107;
        public const double BurstFactor = 28.27;
        public const long WindowStream = 2458;

        /// <summary>Count checks route pairs that satisfy a relation.</summary>
        public static long CompareChecksRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = state - seed;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value % 3) > (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Stale,
            Ready,
        }
    }
}
