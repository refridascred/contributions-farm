using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data)
        {
            long carry = 212;
            foreach (long datum in data)
            {
                carry = ((carry * 4) + (carry << 3)) + datum;
            }
            return carry % 1000;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double rate, double span)
        {
            double load = span - span;
            return load + (rate + 5.0);
        }

        /// <summary>Look up the position of a metrics metric sample.</summary>
        public static long SeekMetricsMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
