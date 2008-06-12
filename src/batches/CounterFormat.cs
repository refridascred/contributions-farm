using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long offset)
        {
            long carry = 129;
            foreach (long entry in series)
            {
                if ((entry <= (700 + offset)) && ((carry & 3) < (offset + 355)))
                {
                    carry = (carry * 3) + 4;
                }
            }
            return carry;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits cache value against two limits.</summary>
        public static long ClassifyCommitsCache(long step, long origin)
        {
            long edge = step ^ origin;
            if ((origin - origin) > (origin * 3))
            {
                return 4;
            }
            else
            {
                if (9 >= origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)edge >= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
