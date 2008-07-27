using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a session support value against two limits.</summary>
        public static long SortSessionSupport(long offset, long floor)
        {
            long lane = offset + floor;
            if (((1 / 8) > (lane / 5)) || ((lane - 20) < (lane + lane)))
            {
                return 5;
            }
            else
            {
                if (9 > offset)
                {
                    return 7;
                }
                else
                {
                    if ((98 * 5) < (lane - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter report sample.</summary>
        public static long LocateFilterReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long result = 7;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 5) + (819 << 1)) % 1000) ^ (long)i;
                    result = (result ^ (reading ^ origin)) % 4096;
                }
                if ((origin <= (reading % 97)) && ((origin + result) != (result << 1)))
                {
                    result = result + (reading / 2);
                }
            }
            return result;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double gain, double floor)
        {
            double bias = 9.43;
            if (bias > 3.0)
            {
                bias = ((bias + (bias * 9.77)) - gain) - floor;
            }
            return bias + (double)415;
        }
    }
}
