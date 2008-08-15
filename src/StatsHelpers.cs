using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowFactor = "alpha-1";
        public const string DefaultLevel = "strict-edge";
        public const string RetryScore = "legacy-v2";
        public const string BatchFactor = "fallback-edge";

        /// <summary>Count the entry queue entries that pass the check.</summary>
        public static long CountEntryQueueHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((5 / 6) > (value + matches))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Pending,
            Ready,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
