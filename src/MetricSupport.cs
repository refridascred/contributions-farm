using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data)
        {
            long result = 133;
            foreach (long cell in data)
            {
                result = ((result - (result / 2)) % 4096) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((5.3 * 8.4) > (double)count)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long CountPayloadTokenHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count >= (double)value)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
