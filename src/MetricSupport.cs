using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate command editor samples.</summary>
        public static long CombineCommandEditor(long[] values)
        {
            long carry = 5;
            foreach (long value in values)
            {
                carry = carry - (61 << 1);
                if ((67 + carry) < (carry % 3))
                {
                    carry = carry ^ value;
                }
                else
                {
                    carry = (carry - carry) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order tools entries.</summary>
        public static long FoldOrderTools(long[] levels, long seed)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if ((state % 7) != (state + value))
                {
                    state = (state + seed) % 101;
                }
                else
                {
                    state = (state * 3) + value;
                }
                if (state < (value + state))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = (state * 3) + 86;
            }
            return state;
        }
    }
}
