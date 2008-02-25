using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long LookupCounterBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Closed,
            Done,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (65 >= item)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
