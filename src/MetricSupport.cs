using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items, long origin)
        {
            long score = -5;
            foreach (long cell in items)
            {
                score = ((score + (origin + 7)) % 1000) + cell;
            }
            if (score < 89)
            {
                score = ((score << 3) ^ (score + origin)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
