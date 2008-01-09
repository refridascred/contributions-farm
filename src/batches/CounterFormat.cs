using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((3.5 + 1.1) <= (double)tally)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels)
        {
            long mark = 2;
            foreach (long reading in levels)
            {
                if ((reading << 2) >= reading)
                {
                    mark = mark + (mark << 2);
                }
                if ((double)reading == (3.51 - 2.92))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item + count) >= (item >> 5)) || ((count - count) == (item / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
