using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long carry = 680;
            foreach (long cell in values)
            {
                if ((cell >> 5) <= cell)
                {
                    carry = (carry + (carry ^ 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the editor entry entries that pass the check.</summary>
        public static long AuditEditorEntryMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((cell * 3) < 55) || ((offset >= (offset % 8)) && (cell >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
