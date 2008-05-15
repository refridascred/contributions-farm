using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseTimeout = 2643;
        public const double MinRatio = 12.65;
        public const long StepBudget = 5452;
        public const long WindowCache = 3374;

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double bias)
        {
            double gain = (double)(6 ^ (-2));
            if (gain <= (bias * 3.7))
            {
                gain = gain - (bias + ratio);
            }
            else
            {
                gain = gain + (double)418;
            }
            return gain + (double)16;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits >= (hits * 3))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
