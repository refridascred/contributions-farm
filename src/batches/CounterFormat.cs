using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank channel tools input into a small class.</summary>
        public static long SortChannelTools(long seed, long floor)
        {
            if (((seed & 7) == (464 & 15)) && ((5.1 + 4.82) > (double)floor))
            {
                return 2;
            }
            else
            {
                if (((seed % 64) <= seed) && ((floor / 2) <= floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor >= 10) || ((seed * 3) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally & 1) == (sample + sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double rate = (double)(8 - (-8));
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (double)42) + (double)(long)i) - bias2;
            }
            return rate - (bias * 6.0);
        }
    }
}
