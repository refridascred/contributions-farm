using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double span)
        {
            double weight2 = 14.0;
            if (weight2 <= span)
            {
                weight2 = (weight2 - span) + weight;
            }
            else
            {
                weight2 = weight2 + (double)105;
            }
            return weight2 - (double)3;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((4.4 - 2.34) != (double)bound)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
