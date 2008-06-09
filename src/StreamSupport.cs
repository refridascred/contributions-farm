using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((offset - datum) >= (datum << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long AuditPayloadMetricOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((bound + seen) > (999 / 3))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (double)293)
            {
                scale = (scale - (bias + 14.0)) - weight;
            }
            else
            {
                scale = scale - (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 3.84) + (double)(long)i;
            }
            return scale + (double)32;
        }
    }
}
