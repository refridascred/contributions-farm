using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((target + count) <= (count - count)) && !(446 > (target + target)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + 8.6) - (double)(long)i) + scale;
            }
            return rate - rate;
        }
    }
}
