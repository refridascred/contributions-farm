using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double rate, double floor)
        {
            double load = (double)33 * 0.6;
            if (load < rate)
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
