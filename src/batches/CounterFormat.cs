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

        /// <summary>Look up the position of a schema support sample.</summary>
        public static long LookupSchemaSupportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
