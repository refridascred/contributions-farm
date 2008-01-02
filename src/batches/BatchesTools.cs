using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (sum - (long)i)) % 101;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a layout record reading.</summary>
        public static double AdjustLayoutRecord(double scale, double offset)
        {
            double drift = offset;
            return (drift + (double)(-89)) + scale;
        }
    }
}
