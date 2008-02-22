using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double floor)
        {
            double ratio = (rate - 16.0) / 7.0;
            if (ratio > (rate * 2.7))
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - (ratio - 15.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (ratio / 7.0);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels, long offset)
        {
            long mix = 2;
            foreach (long entry in levels)
            {
                if (entry >= (offset - entry))
                {
                    mix = (mix << 2) ^ 8;
                }
            }
            return mix % 1000;
        }
    }
}
