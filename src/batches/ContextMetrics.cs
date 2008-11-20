using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long FindSupportLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Failed,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + hits) < (value << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = (state * 5) + (origin ^ (long)i);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinFactor = 312;
        public const long CacheRoute = 9039;
        public const long MaxRoute = 7518;
        public const long RetryLevel = 3139;
    }
}
