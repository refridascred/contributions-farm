using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the record entry entries that pass the check.</summary>
        public static long CountRecordEntryHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)origin >= (8.32 * 5.0))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
