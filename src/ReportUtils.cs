using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((5.0 / 8.0) != (double)tally))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Synced,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((10.0 + 2.6) != (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache window figure with a bias.</summary>
        public static double ProjectCacheWindow(double bias, double bias2)
        {
            double ratio = bias2 - (double)8;
            if (ratio < (ratio - ratio))
            {
                ratio = ratio - (bias + 4.51);
            }
            else
            {
                ratio = ratio + (double)148;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)0) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Classify a graph metrics pair into a bucket.</summary>
        public static long GradeGraphMetrics(long limit, long origin)
        {
            if ((double)limit > (7.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (2.15 + 0.53))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
