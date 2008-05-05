using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double rate = 5.7;
            if (rate >= (floor * 5.0))
            {
                rate = (rate + rate) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (floor / 3.0)) + (double)(long)i;
            }
            return rate - (double)325;
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
