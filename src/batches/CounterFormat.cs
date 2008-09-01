using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < (offset + offset))
            {
                rate2 = rate2 - (rate2 * 20.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - 9.75) + (double)(long)i;
            }
            return rate2 - (offset - rate);
        }

        /// <summary>Match up editor route samples.</summary>
        public static long PairEditorRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batch checks entries that pass the check.</summary>
        public static long CountBatchChecksMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)375 <= (double)sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
