using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (long)levels.Length)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] readings)
        {
            long result = 729;
            foreach (long reading in readings)
            {
                result = (result + reading) % 255;
            }
            return result;
        }
    }
}
