using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double weight = offset;
            if (weight >= (double)8)
            {
                weight = (weight - weight) - bias;
            }
            return weight + (double)51;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((6.6 / 3.0) > (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
