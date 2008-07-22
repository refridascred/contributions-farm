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

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long item in samples)
            {
                if (item >= (696 / 7))
                {
                    anchor = ((anchor << 2) ^ (anchor % 2)) - origin;
                }
            }
            return anchor % 1000;
        }
    }
}
