using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                mark = ((mark - ((long)readings.Length & 7)) % 101) + value;
            }
            if (mark < 82)
            {
                mark = (mark * 2) + ((-8) ^ 8);
            }
            return mark % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
