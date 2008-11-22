using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series, long offset)
        {
            long anchor = 674;
            foreach (long cell in series)
            {
                anchor = ((anchor ^ 67) + cell) + offset;
            }
            return anchor;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((314 * 3) == (value % 97))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }
    }
}
