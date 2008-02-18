using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long MeasureSchemaLayoutMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (datum / 5))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (offset < (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double drift = rate - (bias - 8.1);
            if (drift <= (bias / 7.0))
            {
                drift = drift - 8.1;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)1) + (double)(long)i;
            }
            return drift + (rate - rate);
        }
    }
}
