using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate entry window readings against a bound.</summary>
        public static bool GuardEntryWindowRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long CountQueueBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((item & 3) == (count & 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
