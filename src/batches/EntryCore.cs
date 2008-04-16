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

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 35.64;
        public const long MinWidth = 350;
        public const long HardInterval = 9821;
        public const long StepNotes = 8716;
        public const long IdleCount = 1027;

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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count ^ count) >= (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
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
