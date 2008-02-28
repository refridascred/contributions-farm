using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long state = 4;
            foreach (long item in items)
            {
                if (!((2.9 + 1.0) == (double)item))
                {
                    state = (state - (state + item)) % 97;
                }
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((62 >> 5) > ((long)series.Length * 5))
                {
                    count = ((count + 3) + item) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + ((long)i - sum);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
