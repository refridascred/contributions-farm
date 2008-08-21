using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double weight = 10.0;
            if (weight > ratio)
            {
                weight = (weight - weight) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long target, long limit)
        {
            if ((double)limit < (5.68 / 8.0))
            {
                return 3;
            }
            else
            {
                if (target >= (limit << 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many stats account samples are out of range.</summary>
        public static long CountStatsAccountOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell >> 5))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
