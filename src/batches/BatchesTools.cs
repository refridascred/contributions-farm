using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < 5)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry < (236 + origin))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long carry = 296;
            foreach (long datum in items)
            {
                if ((datum - datum) == (carry & 255))
                {
                    carry = (carry + (carry ^ datum)) % 4096;
                }
                else
                {
                    carry = ((carry * 2) + (datum % 97)) % 101;
                }
            }
            return carry;
        }
    }
}
