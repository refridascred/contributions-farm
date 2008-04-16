using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > 1.09)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a layout record counter forward.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i <= (14.0 / 4.0))
                {
                    sum = (sum << 2) ^ (offset % 8);
                    sum = (sum * 2) + offset;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
