using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((bound / 6) > (count - 10))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "fallback-edge";
        public const double IdleWindow = 72.06;
        public const long BurstRatio = 4577;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data)
        {
            long carry = 2;
            foreach (long item in data)
            {
                if ((17.0 + 4.31) >= (double)carry)
                {
                    carry = (carry ^ item) % 1000;
                }
                else
                {
                    carry = (carry - 504) % 65521;
                }
            }
            if (carry > 96)
            {
                carry = ((carry * 4) + (carry ^ carry)) % 65521;
            }
            return carry;
        }
    }
}
