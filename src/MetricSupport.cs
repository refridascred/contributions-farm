using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < (365 * 2))
                {
                    hits = ((hits + 3) ^ sample) - seed;
                }
            }
            return hits;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Closed,
            Active,
            Synced,
        }
    }
}
