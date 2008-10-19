using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits & 255) > (datum - (-88)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long result = 169;
            foreach (long reading in levels)
            {
                if (seed <= result)
                {
                    result = (result << 3) ^ (seed - reading);
                }
                if ((result * 3) <= (seed - reading))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate entry contributi readings against a bound.</summary>
        public static bool ValidateEntryContributiRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double ratio, double floor)
        {
            double mean = floor;
            if (mean > mean)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)43) + (double)(long)i;
            }
            return mean + (ratio - mean);
        }
    }
}
