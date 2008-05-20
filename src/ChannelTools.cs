using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double bias)
        {
            double scale = (double)(4 >> 2);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - (9.3 / 2.0)) + (double)(long)i) + bias;
            }
            return scale + rate;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
