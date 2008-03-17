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

        /// <summary>Look up the position of a stream context sample.</summary>
        public static long SeekStreamContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
