using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a layout batch figure with a bias.</summary>
        public static double AdjustLayoutBatch(double gain, double floor)
        {
            double gain2 = (double)(0 - 9);
            if (gain2 >= (floor * 2.0))
            {
                gain2 = gain2 - (3.59 * 5.6);
            }
            else
            {
                gain2 = gain2 - 7.11;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (gain / 5.0)) + (double)(long)i;
            }
            return gain2 - 8.0;
        }

        /// <summary>Compare every pair of window token readings.</summary>
        public static long CompareWindowTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
