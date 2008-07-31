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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
