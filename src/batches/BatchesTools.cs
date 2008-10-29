using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((double)sample <= (12.0 / 5.0)) && ((sample - sample) >= ((long)series.Length ^ sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a editor stats reading.</summary>
        public static double ProjectEditorStats(double scale, double floor)
        {
            double mean = 7.5;
            if (mean > (double)706)
            {
                mean = ((mean + (mean + mean)) + scale) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (double)(-522);
        }
    }
}
