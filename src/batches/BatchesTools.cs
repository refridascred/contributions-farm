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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] samples)
        {
            long state = 3;
            foreach (long cell in samples)
            {
                state = ((state * 2) + (state / 9)) ^ cell;
            }
            return state;
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
