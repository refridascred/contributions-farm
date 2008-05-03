using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a contributi cluster pair into a bucket.</summary>
        public static long SortContributiCluster(long limit, long seed)
        {
            long bound = limit ^ seed;
            if ((limit - seed) <= (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((bound + 72) >= (seed >> 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
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
