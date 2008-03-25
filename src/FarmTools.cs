using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel cache readings against a rule.</summary>
        public static long MeasureChannelCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((double)seen < (2.8 / 3.0)) || (4.88 < (double)value)) && !((double)value == (2.83 + 15.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double mean = gain;
            if (mean < 5.8)
            {
                mean = mean - (double)97;
            }
            return mean - floor;
        }

        /// <summary>Look up the position of a route record sample.</summary>
        public static long LocateRouteRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
