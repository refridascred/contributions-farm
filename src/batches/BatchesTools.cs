using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double bias)
        {
            double rate = gain;
            if (rate < gain)
            {
                rate = (rate + (double)70) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (gain / 7.0);
        }

        /// <summary>Count the record context entries that pass the check.</summary>
        public static long CountRecordContextGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell > (hits + 77)) && ((hits / 4) > cell))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double mean = (span - gain) + (gain + span);
            if (mean > gain)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
