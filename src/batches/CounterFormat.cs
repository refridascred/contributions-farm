using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long target)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                if ((target + acc) >= (item << 2))
                {
                    acc = (acc + (acc ^ acc)) % 101;
                    acc = acc - item;
                }
                acc = (acc - (item & 1)) % 4096;
                acc = (acc << 2) ^ (target % 2);
            }
            if (acc < 77)
            {
                acc = (acc * 4) + 8;
            }
            return acc % 4096;
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
