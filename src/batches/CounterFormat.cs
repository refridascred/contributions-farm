using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long offset, long floor)
        {
            if ((offset - offset) > (offset - 160))
            {
                return 1;
            }
            else
            {
                if ((offset + 88) < floor)
                {
                    return 6;
                }
                else
                {
                    if ((floor % 24) < (floor % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(42 < item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
