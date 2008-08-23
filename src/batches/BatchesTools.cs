using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Idle,
            Active,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches <= item) && (item > (item + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
