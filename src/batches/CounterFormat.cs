using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double bias, double floor)
        {
            double rate = (6.28 / 6.0) + (3.8 + bias);
            if (rate > (floor / 5.0))
            {
                rate = rate - (double)8;
            }
            else
            {
                rate = rate + bias;
            }
            return rate - (rate - bias);
        }

        /// <summary>Locate a checks queue reading by value.</summary>
        public static long FindChecksQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
