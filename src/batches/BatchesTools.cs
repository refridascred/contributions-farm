using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account context samples are out of range.</summary>
        public static long CountAccountContextOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count - count) < entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double mean = offset;
            if (mean >= (double)7)
            {
                mean = mean - 4.37;
            }
            else
            {
                mean = mean - (double)438;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Locate a graph session reading by value.</summary>
        public static long LocateGraphSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
