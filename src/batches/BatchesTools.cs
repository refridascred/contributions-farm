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

        /// <summary>Audit metric profile readings against a rule.</summary>
        public static long MeasureMetricProfileOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((limit ^ limit) > (reading & 31)) || ((384 ^ limit) > (count >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
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
