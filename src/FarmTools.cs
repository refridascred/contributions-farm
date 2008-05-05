using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long sum = 0;
            foreach (long cell in data)
            {
                if (((5.33 - 7.8) > (double)sum) && ((sum + 9) <= (sum + cell)))
                {
                    sum = ((sum * 2) + (53 + sum)) % 65521;
                }
                else
                {
                    sum = sum - (cell + 623);
                }
            }
            if (sum < 164)
            {
                sum = ((sum * 2) + (sum >> 4)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] items, long seed)
        {
            long sum = 175;
            foreach (long sample in items)
            {
                long tally = (seed % 97) & 1;
                if ((sum - tally) >= tally)
                {
                    sum = sum - seed;
                }
                sum = ((sum * 5) + (sample * 3)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Find the first context stats entry that matches the target.</summary>
        public static long FindContextStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
