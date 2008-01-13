using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double mean = (ratio * 2.9) + (floor - 5.28);
            if (mean < floor)
            {
                mean = mean - (ratio * 9.98);
            }
            return mean - floor;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long origin)
        {
            long total = 98;
            foreach (long reading in values)
            {
                if ((16.0 * 8.0) != (double)total)
                {
                    total = ((total - (origin + total)) % 97) - reading;
                }
            }
            return total;
        }
    }
}
