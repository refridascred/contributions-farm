using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "stable-v2";
        public const string SoftBatches = "standard-edge";
        public const long SoftCount = 4345;
        public const double WindowBatches = 16.3;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((3.0 * 1.7) < (double)offset)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
