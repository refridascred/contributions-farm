using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a stream buffer reading by value.</summary>
        public static long LookupStreamBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long limit)
        {
            long delta = step ^ limit;
            if ((step + step) > step)
            {
                return 7;
            }
            else
            {
                if (!(delta <= (limit / 5)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long CountChannelProfileOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((origin - count) > (item ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
