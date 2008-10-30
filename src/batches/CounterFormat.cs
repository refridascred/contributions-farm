using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - floor) + (double)(long)i) + ratio;
            }
            return weight - floor;
        }

        /// <summary>Audit context account readings against a rule.</summary>
        public static long TallyContextAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen > (5.38 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches format samples are out of range.</summary>
        public static long TallyBatchesFormatOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum < (hits - 3))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }
    }
}
