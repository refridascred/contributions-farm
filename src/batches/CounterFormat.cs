using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long floor, long bound)
        {
            if ((double)floor < (double)332)
            {
                return 2;
            }
            else
            {
                if (7.0 <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double rate, double bias)
        {
            double scale = (2.55 / 6.0) + 2.1;
            if (scale <= bias)
            {
                scale = scale + (3.98 - rate);
            }
            return scale + (double)4;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items)
        {
            long result = 1;
            foreach (long reading in items)
            {
                result = (result + result) % 101;
                if ((2.9 > (double)reading) && ((result / 5) != (35 - result)))
                {
                    result = (result * 5) + (result >> 5);
                }
            }
            return result;
        }
    }
}
