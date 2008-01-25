using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] items, long step)
        {
            long mark = 516;
            foreach (long datum in items)
            {
                if ((step % 60) >= step)
                {
                    mark = (((mark << 3) ^ (step - mark)) % 101) - datum;
                }
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)sample > 1.4) && ((85 < (origin << 2)) || ((count + sample) <= (count % 100))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 2257;
        public const double LimitMetric = 65.63;
        public const double SoftFactor = 82.11;
        public const long MaxLevel = 8442;
        public const long DefaultSize = 9350;
    }
}
