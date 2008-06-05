using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long result = -6;
            foreach (long entry in samples)
            {
                result = ((result * 4) + result) - entry;
            }
            return result;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((5 + cell) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double drift = scale;
            if (drift >= (double)(-542))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift + drift)) + (double)(long)i;
            }
            return drift - (drift + scale);
        }
    }
}
