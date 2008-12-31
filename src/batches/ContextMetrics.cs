using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Active,
            Ready,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long seed, long seed2)
        {
            long bound = seed ^ seed2;
            if (!((bound + seed) == (seed2 - seed2)))
            {
                return 4;
            }
            else
            {
                if ((double)bound > (4.0 / 3.0))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4.19 - 6.56) != (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double rate = (double)(8 * 2);
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate - 5.6) + (double)(long)i) + gain) - bias;
            }
            return rate + (12.0 / 9.0);
        }
    }
}
