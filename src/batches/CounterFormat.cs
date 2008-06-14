using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples, long floor)
        {
            long sum = -50;
            foreach (long cell in samples)
            {
                if ((sum << 2) > (floor + floor))
                {
                    sum = (((sum << 3) ^ ((-169) - sum)) % 4096) + cell;
                }
                else
                {
                    sum = (sum * 2) + (floor + sum);
                }
            }
            return sum;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double span)
        {
            double rate = (double)(8 & 127);
            if (rate > rate)
            {
                rate = (rate - 3.6) + span;
            }
            else
            {
                rate = rate + (20.0 / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)125) + (double)(long)i;
            }
            return rate + (weight - weight);
        }

        /// <summary>Count record contributi pairs that satisfy a relation.</summary>
        public static long PairRecordContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
