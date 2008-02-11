using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a commits cache figure with a bias.</summary>
        public static double BlendCommitsCache(double bias, double bias2)
        {
            double weight = (2.2 + 9.5) / 4.0;
            if (weight < (13.0 + 7.3))
            {
                weight = (weight + 14.0) - bias2;
            }
            return weight - (bias / 2.0);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((66 + limit) > 975) && ((limit > (limit ^ matches)) || ((matches * 5) == (matches >> 4))))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
