using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the buffer channel entries that pass the check.</summary>
        public static long CountBufferChannelOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((target - count) != (target % 8))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
