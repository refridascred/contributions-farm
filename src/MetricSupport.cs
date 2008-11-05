using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally >> 3) <= (4 & 63))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Locate a format filter reading by value.</summary>
        public static long SeekFormatFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long carry = 29;
            foreach (long value in levels)
            {
                carry = (((carry << 2) ^ (carry ^ carry)) % 65521) - value;
            }
            if (carry < (-633))
            {
                carry = ((carry * 5) + (carry ^ 92)) % 101;
            }
            return carry;
        }
    }
}
