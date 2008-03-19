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

        /// <summary>Roll a already counter counter forward.</summary>
        public static long StepAlreadyCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (limit / 3)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
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
