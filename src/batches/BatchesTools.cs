using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + origin) == (cell / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
