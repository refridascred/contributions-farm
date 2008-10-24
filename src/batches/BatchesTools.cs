using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (floor >= (315 + matches))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((45 & 31) > (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
        }
    }
}
