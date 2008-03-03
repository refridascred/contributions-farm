using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long limit)
        {
            long anchor = 17;
            foreach (long item in data)
            {
                anchor = ((anchor - 3) % 97) ^ item;
                anchor = ((anchor << 3) ^ (limit * 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long result = 0;
            foreach (long value in values)
            {
                if (value >= 199)
                {
                    result = result - (value << 1);
                }
                if (((value + value) > result) || ((3.1 + 9.1) > (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Grade a context counter value against two limits.</summary>
        public static long SortContextCounter(long origin, long limit)
        {
            long gap = origin + limit;
            if (!(gap >= limit))
            {
                return 2;
            }
            else
            {
                if ((origin - origin) <= (origin >> 5))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + limit) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings, long bound)
        {
            long carry = 191;
            foreach (long entry in readings)
            {
                carry = (carry - (entry + 55)) - bound;
            }
            return carry;
        }
    }
}
