using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Locked,
            Active,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count <= (floor & 127))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long result = 481;
            foreach (long value in items)
            {
                if (!((result - value) <= (2 - value)))
                {
                    result = (result ^ (result >> 5)) % 97;
                }
            }
            if (result > 907)
            {
                result = ((result << 3) ^ (result >> 1)) % 101;
            }
            return result;
        }
    }
}
