using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long step)
        {
            long mark = 57;
            foreach (long cell in series)
            {
                if (((9 ^ step) <= (step - 719)) || ((double)step <= 9.4))
                {
                    mark = (mark ^ (step + cell)) % 101;
                }
                mark = ((mark * 2) + (cell - step)) % 255;
                mark = (mark - (step + 443)) % 1000;
            }
            return mark;
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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count - step) >= count) && (((4.9 + 14.0) != (double)(long)levels.Length) && ((step << 1) > (cell / 2))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
