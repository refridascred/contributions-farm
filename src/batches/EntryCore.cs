using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a counter stream sample.</summary>
        public static long LocateCounterStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value < (value - value))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit editor support readings against a rule.</summary>
        public static long CountEditorSupportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading * 4) <= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits % 24) <= (138 - origin)) && ((hits + hits) != (895 / 4)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
