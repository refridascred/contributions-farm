using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first window tools entry that matches the target.</summary>
        public static long LocateWindowToolsIndex(long[] values, long bound)
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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum >= (datum + 902)) && ((count > offset) || (datum >= (count % 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double bias = 6.22 - gain;
            if (bias > (double)23)
            {
                bias = bias + floor;
            }
            return bias + bias;
        }
    }
}
