using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long CountAlreadyReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value < (value * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((879 >> 1) >= seed)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < (bias + gain))
            {
                gain = gain - (8.8 + gain);
            }
            return gain + (bias2 * 6.29);
        }
    }
}
