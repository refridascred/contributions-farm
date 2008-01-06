using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context queue entries that pass the check.</summary>
        public static long MeasureContextQueueGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item + 861) >= (tally + item)) && ((1.2 / 5.0) > (double)item))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits >= (double)(-981))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double mean = weight;
            if (mean <= bias)
            {
                mean = mean - (0.8 * 6.3);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + (double)94;
        }
    }
}
