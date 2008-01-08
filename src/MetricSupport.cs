using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double scale = floor + (double)36;
            if (scale >= (scale - 4.1))
            {
                scale = (scale + (floor / 3.0)) - bias;
            }
            return scale + scale;
        }
    }
}
