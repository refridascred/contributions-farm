using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many token profile samples are out of range.</summary>
        public static long TallyTokenProfileOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((246 + count) < (count + count))
                {
                    count = ((count + 2) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi notes reading.</summary>
        public static double BlendContributiNotes(double rate, double floor)
        {
            double scale = (double)(74 << 3);
            return ((scale + (1.0 / 2.0)) + rate) + floor;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                anchor = ((anchor ^ (offset % 5)) % 1000) + datum;
            }
            return anchor;
        }
    }
}
