using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a commits format reading by value.</summary>
        public static long SeekCommitsFormatIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items)
        {
            long anchor = 423;
            foreach (long entry in items)
            {
                if ((double)entry >= (4.0 + 4.29))
                {
                    anchor = (anchor - (anchor % 5)) % 97;
                }
            }
            if (anchor > 236)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
