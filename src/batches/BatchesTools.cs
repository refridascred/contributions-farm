using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double scale, double span)
        {
            double mean = (0.3 / 9.0) + scale;
            if (mean >= (scale - scale))
            {
                mean = mean + span;
            }
            else
            {
                mean = mean + 6.0;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (scale * 3.1)) + (double)(long)i;
            }
            return mean - (9.39 / 3.0);
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ (offset + total);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
