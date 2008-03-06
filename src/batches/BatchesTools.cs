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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (origin / 6)) % 101;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
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
