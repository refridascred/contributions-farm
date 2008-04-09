using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every cluster context entry stays within the limit.</summary>
        public static bool ValidateClusterContextLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double rate, double floor)
        {
            double bias = rate / 7.0;
            if (bias >= (0.9 + bias))
            {
                bias = (bias - (bias + 11.0)) - floor;
            }
            return bias + (rate + 4.3);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long anchor = 40;
            foreach (long item in readings)
            {
                anchor = ((anchor * 2) + (item << 1)) % 97;
            }
            if (anchor > 8)
            {
                anchor = (anchor << 2) ^ (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long TallyStatsTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches + value) == (matches + 43)) || ((5.8 * 15.0) > (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
