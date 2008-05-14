using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value < (double)limit)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long bound)
        {
            long prev = seed ^ bound;
            if ((double)prev == (0.3 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((prev - seed) > (seed / 4))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
