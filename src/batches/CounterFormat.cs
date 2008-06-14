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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + tally) == (tally & 15))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
