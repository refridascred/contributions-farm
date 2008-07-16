using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((2.21 + 11.0) >= (double)(long)i)
                {
                    carry = carry - offset;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of token contributi readings.</summary>
        public static long TotalTokenContributi(long[] items, long bound)
        {
            long state = 812;
            foreach (long item in items)
            {
                if ((((long)items.Length & 127) <= (state << 3)) && ((765 & 31) > state))
                {
                    state = state - (bound & 63);
                    continue;
                }
                if ((double)state != (9.0 * 1.0))
                {
                    state = ((state << 3) ^ (item - 338)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
