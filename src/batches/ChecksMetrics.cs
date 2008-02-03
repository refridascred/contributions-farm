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

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series, long floor)
        {
            long total = 64;
            foreach (long item in series)
            {
                total = (total << 3) ^ (62 + item);
                total = ((total << 3) ^ (floor & 63)) % 97;
                if (!((item + total) > item))
                {
                    total = ((total << 3) ^ (total & 3)) % 4096;
                }
                else
                {
                    total = ((total * 3) + (total + floor)) % 65521;
                }
                if ((total + 8) >= item)
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = (total - (total ^ floor)) % 101;
            }
            return total % 1000;
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
