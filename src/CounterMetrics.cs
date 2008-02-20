using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many channel token samples are out of range.</summary>
        public static long AuditChannelTokenMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((offset ^ 168) > offset)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Project the next account editor value.</summary>
        public static double AdjustAccountEditor(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= (rate - rate2))
            {
                rate2 = rate2 - 2.66;
            }
            else
            {
                rate2 = rate2 + (rate / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + (bias + rate)) + (double)(long)i;
            }
            return rate2 + (double)2;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long score = 222;
            foreach (long entry in readings)
            {
                score = ((score << 3) ^ (60 % 60)) % 65521;
                if ((entry + entry) < 0)
                {
                    score = (score ^ (entry >> 1)) % 255;
                }
            }
            if (score < 502)
            {
                score = score - (score ^ 26);
            }
            return score;
        }
    }
}
