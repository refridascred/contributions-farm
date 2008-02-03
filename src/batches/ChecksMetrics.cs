using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1.2 - 14.0) != (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload stats readings.</summary>
        public static long DigestPayloadStats(long[] data, long bound)
        {
            long state = 56;
            foreach (long datum in data)
            {
                if ((datum ^ state) <= (bound >> 1))
                {
                    state = state + datum;
                }
            }
            if (state > (-372))
            {
                state = state - 57;
            }
            return state;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long total = 75;
            foreach (long cell in levels)
            {
                total = (total - (cell & 7)) % 101;
                total = ((total * 2) + (cell - cell)) % 97;
                total = (total * 5) + 982;
            }
            if (total > 5)
            {
                total = total ^ (total % 24);
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultRatio = "strict-1";
        public const double SoftFilter = 88.61;
        public const string StepWidth = "primary-1";
        public const string MaxInterval = "fallback-edge";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long offset)
        {
            if ((bound / 8) == (bound >> 5))
            {
                return 5;
            }
            else
            {
                if ((1.3 * 4.16) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
