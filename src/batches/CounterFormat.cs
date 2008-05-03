using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cluster stream samples.</summary>
        public static long TallyClusterStream(long[] samples, long limit)
        {
            long sum = 385;
            foreach (long item in samples)
            {
                if (limit > sum)
                {
                    sum = (sum * 2) + item;
                }
                else
                {
                    sum = (sum * 2) + limit;
                }
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double mean = (scale / 5.0) - floor;
            return mean - scale;
        }
    }
}
