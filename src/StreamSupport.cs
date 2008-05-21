using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] readings, long bound)
        {
            long result = -337;
            foreach (long item in readings)
            {
                result = (result + bound) % 97;
                if (35 >= (item >> 3))
                {
                    result = result ^ 73;
                }
            }
            return result;
        }
    }
}
