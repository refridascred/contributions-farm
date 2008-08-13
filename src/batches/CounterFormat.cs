using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (limit <= (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((900 + prev) == (204 % 2))
                {
                    return 6;
                }
                else
                {
                    if (limit < (78 >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate farm stream samples.</summary>
        public static long CombineFarmStream(long[] levels)
        {
            long result = 562;
            foreach (long datum in levels)
            {
                result = ((result - (result + 828)) % 1000) - datum;
            }
            return result;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
