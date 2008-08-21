using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!!((186 & 3) != (seen - 7)))
                {
                    seen = ((seen + 3) + item) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric profile reading by value.</summary>
        public static long SeekMetricProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
