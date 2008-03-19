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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long seed)
        {
            if ((seed - 23) > (5 * 4))
            {
                return 2;
            }
            else
            {
                if (offset >= (8 + offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset + seed) >= (seed * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
