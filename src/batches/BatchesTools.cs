using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)offset > 10.0)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
