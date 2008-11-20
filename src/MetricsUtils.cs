using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)7) - (double)(long)i;
            }
            return rate - (bias + rate);
        }

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long MeasurePayloadEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches > 4.0)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings)
        {
            long anchor = 218;
            foreach (long datum in readings)
            {
                if (((datum - anchor) >= (anchor % 8)) && ((datum % 2) < datum))
                {
                    anchor = (anchor - datum) % 65521;
                }
            }
            if (anchor > 89)
            {
                anchor = (anchor + (anchor % 3)) % 97;
            }
            return anchor % 1000;
        }
    }
}
