using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first report schema entry that matches the target.</summary>
        public static long LocateReportSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 + (gain * 15.0);
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long offset, long bound)
        {
            if ((double)offset != (5.0 - 5.06))
            {
                return 6;
            }
            else
            {
                if (4.6 >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
