using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long bound2)
        {
            if ((bound2 + bound) > (bound2 + 775))
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound) == (416 - bound2))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double bias = (double)487;
            if (bias <= (double)(-837))
            {
                bias = bias - (ratio * 3.3);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - offset;
        }
    }
}
