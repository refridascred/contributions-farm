using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)bound < (9.31 + 3.81))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample % 3) >= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double weight = 7.5;
            if (weight > (double)77)
            {
                weight = (weight - weight) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (scale - 9.7)) + (double)(long)i;
            }
            return weight + (double)122;
        }
    }
}
