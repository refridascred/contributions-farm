using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double bias = gain;
            if (bias > (floor - bias))
            {
                bias = bias + (floor * 3.0);
            }
            return bias + (gain + bias);
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double scale, double span)
        {
            double ratio = (span / 6.0) / 4.0;
            return (ratio + ratio) + scale;
        }
    }
}
