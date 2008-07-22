using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric tools reading.</summary>
        public static double AdjustMetricTools(double scale, double floor)
        {
            double weight = scale / 5.0;
            if (weight < floor)
            {
                weight = weight + 20.0;
            }
            return weight - floor;
        }

        /// <summary>Digest a series of support entry entries.</summary>
        public static long CombineSupportEntry(long[] series)
        {
            long carry = 972;
            foreach (long cell in series)
            {
                if ((16.0 / 3.0) > (double)cell)
                {
                    carry = ((carry << 2) ^ (carry + 3)) % 97;
                }
            }
            return carry % 4096;
        }
    }
}
