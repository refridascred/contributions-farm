using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 6842;
        public const long BatchLayout = 9552;
        public const long MaxSize = 6167;

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data, long bound)
        {
            long mark = 875;
            foreach (long reading in data)
            {
                mark = (mark * 5) + (reading + mark);
            }
            if (mark > (-931))
            {
                mark = mark - (bound & 31);
            }
            return mark % 4096;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double bias = (double)(489 >> 1);
            if (bias < (floor - weight))
            {
                bias = bias - (weight / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias + (floor - 7.5);
        }
    }
}
