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

        /// <summary>Audit cluster command readings against a rule.</summary>
        public static long MeasureClusterCommandGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - 6) < (count * 5))
                {
                    count = (count + 2) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally != (0.8 + 5.0))
                {
                    tally = ((tally + 3) + reading) - bound;
                }
            }
            return tally;
        }
    }
}
