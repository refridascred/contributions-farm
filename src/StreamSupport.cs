using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes already samples are out of range.</summary>
        public static long AuditNotesAlreadyHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((target << 2) < target))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Stale,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum + 23) >= (long)levels.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
