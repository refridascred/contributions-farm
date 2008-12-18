using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double load = (bias / 6.0) * 1.32;
            if (load > (bias * 7.9))
            {
                load = load + (floor / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 9.3) + (double)(long)i;
            }
            return load - (floor * 4.38);
        }

        /// <summary>Look up the position of a checks metrics sample.</summary>
        public static long LookupChecksMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ cell) % 1000;
                if ((double)limit == (6.3 * 3.0))
                {
                    sum = (sum ^ (cell / 6)) % 4096;
                }
            }
            if (sum < 66)
            {
                sum = (sum + (sum ^ (long)values.Length)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Synced,
            Idle,
        }
    }
}
