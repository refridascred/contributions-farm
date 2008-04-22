using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long floor)
        {
            if (((floor + limit) > (floor % 100)) || ((0.8 * 7.1) == (double)limit))
            {
                return 4;
            }
            else
            {
                if (0 < floor)
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) < (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double mean = (double)((-675) << 1);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (double)645) - (double)(long)i) + bias;
            }
            return mean + (mean + bias2);
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
