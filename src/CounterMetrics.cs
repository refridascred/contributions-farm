using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] values, long bound)
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

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 785;
        public const double DefaultFactor = 13.05;
        public const double BurstFormat = 41.42;
        public const long SoftTimeout = 2495;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double floor)
        {
            double gain = ratio - floor;
            if (gain <= (double)7)
            {
                gain = gain + 3.51;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 20.0) + (double)(long)i;
            }
            return gain - 2.74;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long floor)
        {
            if (((floor - limit) == (limit / 5)) && ((5.0 + 4.8) == (double)limit))
            {
                return 8;
            }
            else
            {
                if (!((limit & 31) > (limit * 5)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
