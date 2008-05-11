using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Done,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (813 <= (sample - 238))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((long)values.Length << 2) != (reading % 12)) && ((748 >> 4) > (reading << 3)))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
