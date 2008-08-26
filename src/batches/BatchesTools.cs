using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a format layout reading.</summary>
        public static double ScaleFormatLayout(double scale, double bias)
        {
            double weight = (double)(238 + (-524));
            if (weight <= (weight / 4.0))
            {
                weight = weight - (bias * 4.0);
            }
            else
            {
                weight = weight - 5.26;
            }
            return weight - scale;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((sample + hits) <= (hits - sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate window entry readings against a bound.</summary>
        public static bool GuardWindowEntryLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
