using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double bias, double offset)
        {
            double bias2 = offset * 2.81;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 + (offset + bias2)) + (double)(long)i) - bias;
            }
            return bias2 + offset;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double mean = offset;
            return (mean - mean) + weight;
        }

        /// <summary>Locate a batch stream reading by value.</summary>
        public static long LocateBatchStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
