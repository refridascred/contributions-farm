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

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double load = floor - (2.0 / 3.0);
            for (int i = 0; i < 7; i++)
            {
                load = ((load - 1.6) + (double)(long)i) + ratio;
            }
            return load + (double)882;
        }
    }
}
