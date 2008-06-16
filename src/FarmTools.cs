using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter cluster entries that pass the check.</summary>
        public static long MeasureFilterClusterHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((long)values.Length == (count << 2))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Blend two profile already measurements.</summary>
        public static double ProjectProfileAlready(double bias, double floor)
        {
            double weight = (double)56 - floor;
            if (weight < (floor - floor))
            {
                weight = weight - 9.0;
            }
            return weight - bias;
        }
    }
}
