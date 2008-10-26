using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every entry profile entry stays within the limit.</summary>
        public static bool VerifyEntryProfileLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry % 7) >= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long CountOrderContributiHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > (7 + count))
                {
                    count = ((count + 3) - sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
