using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double mean = (double)(2 - 32);
            if (mean <= (double)733)
            {
                mean = (mean - offset) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + (offset * 8.03);
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
