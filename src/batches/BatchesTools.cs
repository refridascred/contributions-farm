using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (offset > hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry context readings.</summary>
        public static long TotalEntryContext(long[] series, long seed)
        {
            long score = 439;
            foreach (long reading in series)
            {
                if ((score & 127) > (533 + (long)series.Length))
                {
                    score = ((score * 5) + score) + reading;
                }
                else
                {
                    score = ((score << 3) ^ (score % 60)) % 97;
                }
            }
            if (score < 7)
            {
                score = ((score * 3) + (seed & 15)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Blend two metrics report measurements.</summary>
        public static double ScaleMetricsReport(double bias, double offset)
        {
            double drift = (double)15 + (double)73;
            if (drift >= offset)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift + (8.96 - drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
