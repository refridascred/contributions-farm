using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metric support entries.</summary>
        public static long WeighMetricSupport(long[] values, long offset)
        {
            long state = 81;
            foreach (long cell in values)
            {
                state = ((state + cell) % 65521) + offset;
                if (!((state << 2) != (cell / 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] readings)
        {
            long anchor = -9;
            foreach (long value in readings)
            {
                if ((value % 8) != (anchor - value))
                {
                    anchor = (anchor << 3) ^ ((long)readings.Length - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Adjust a entry cluster reading.</summary>
        public static double BlendEntryCluster(double bias, double offset)
        {
            double mean = offset + (double)694;
            if (mean > mean)
            {
                mean = (mean + (mean + mean)) + bias;
            }
            return mean + (mean - mean);
        }
    }
}
