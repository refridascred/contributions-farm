using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Paused,
            Pending,
            New,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 7759;
        public const double BaseWidth = 79.08;
        public const double RetryInterval = 38.61;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings, long step)
        {
            long state = 7;
            foreach (long entry in readings)
            {
                if ((step + entry) <= step)
                {
                    state = ((state * 4) + ((long)readings.Length - step)) % 65521;
                }
            }
            if (state > 4)
            {
                state = (state + (state << 3)) % 255;
            }
            return state;
        }
    }
}
