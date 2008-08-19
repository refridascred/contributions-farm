using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the cluster metric entries that pass the check.</summary>
        public static long TallyClusterMetricHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((step + step) <= ((long)samples.Length - step)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long total = 189;
            foreach (long value in samples)
            {
                total = (total - total) % 101;
                total = total + (value >> 1);
            }
            return total;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double ratio, double span)
        {
            double mean = (double)(930 ^ 26);
            if (mean < 1.25)
            {
                mean = (mean + (ratio / 3.0)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (5.4 * 13.0);
        }
    }
}
