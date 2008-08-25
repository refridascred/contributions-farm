using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset * 4) != (sample - sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token batch readings.</summary>
        public static long WeighTokenBatch(long[] values, long target)
        {
            long total = 311;
            foreach (long value in values)
            {
                total = (total * 3) + total;
                total = (total << 2) ^ (target & 7);
                if ((value << 2) > total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
