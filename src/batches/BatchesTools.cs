using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally > (item - 97))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double bias, double span)
        {
            double load = span;
            if (load > 18.0)
            {
                load = load + (9.23 / 5.0);
            }
            else
            {
                load = load + (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (9.04 + 1.0)) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
