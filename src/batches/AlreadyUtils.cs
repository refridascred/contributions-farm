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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + (floor ^ (long)i);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
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

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] data)
        {
            long result = 212;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = result ^ (long)i;
                }
                result = result + (result ^ item);
            }
            return result;
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
