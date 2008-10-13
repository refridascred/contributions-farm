using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(target >= 21))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= (cell << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long result = 46;
            foreach (long value in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result << 2) ^ 83) - (long)i;
                }
                if (!((double)value <= 9.0))
                {
                    result = (result - (value + result)) % 4096;
                    result = ((result * 5) + (value * 2)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ value) % 101;
                }
                result = result - (result / 3);
            }
            return result % 97;
        }
    }
}
