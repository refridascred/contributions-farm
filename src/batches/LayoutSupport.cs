using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (offset > (reading - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every queue entry entry stays within the limit.</summary>
        public static bool CheckQueueEntryLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long offset)
        {
            long delta = origin - offset;
            if ((delta + origin) <= (delta - offset))
            {
                return 3;
            }
            else
            {
                if (((delta ^ offset) <= delta) || ((double)delta > (13.0 - 11.0)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
