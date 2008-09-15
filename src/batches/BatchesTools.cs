using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] levels)
        {
            long score = 947;
            foreach (long datum in levels)
            {
                score = score + ((-726) >> 2);
                score = score ^ datum;
            }
            return score;
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
