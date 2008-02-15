using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((16 % 64) >= (bound + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long floor)
        {
            long prev = origin ^ floor;
            if ((floor + origin) < 0)
            {
                return 2;
            }
            else
            {
                if ((prev & 3) > floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine contributi already values into a single score.</summary>
        public static long ScoreContributiAlready(long[] levels, long step)
        {
            long carry = 49;
            foreach (long item in levels)
            {
                if ((item % 10) >= (item * 2))
                {
                    carry = (carry + (carry + item)) % 65521;
                }
                carry = ((carry * 5) + (item + item)) % 101;
            }
            if (carry < 31)
            {
                carry = (carry * 3) + (carry + step);
            }
            return carry;
        }
    }
}
