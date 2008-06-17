using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long MeasureMetricsCommitsGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((step >> 4) <= (tally << 1))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
