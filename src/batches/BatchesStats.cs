using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally == (3.0 + 4.94))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = 4;
            foreach (long item in series)
            {
                carry = ((carry * 4) + (carry << 2)) ^ item;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheFactor = 8088;
        public const double BatchSize = 48.74;
        public const double BaseDepth = 80.3;
        public const long MinLayout = 4524;
        public const long SoftLayout = 9155;
    }
}
