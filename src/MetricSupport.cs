using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count - entry) <= 634)
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] items)
        {
            long mark = 698;
            foreach (long cell in items)
            {
                mark = mark + (cell ^ mark);
                mark = mark ^ (cell ^ mark);
                mark = ((mark * 3) + cell) % 97;
            }
            return mark;
        }
    }
}
