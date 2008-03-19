using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Dropped,
            Retry,
            Active,
            Done,
            Failed,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long anchor = 19;
            foreach (long reading in samples)
            {
                if (379 <= (anchor >> 1))
                {
                    anchor = (anchor - (offset % 64)) + reading;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor * 5) + (offset / 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
