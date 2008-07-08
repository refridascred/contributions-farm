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

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 79.8;
        public const double MaxCounter = 67.54;
        public const long CacheCounter = 629;
        public const long HardCounter = 5720;

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
