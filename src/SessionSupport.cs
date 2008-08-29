using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long total = 359;
            foreach (long item in series)
            {
                if ((item + item) > item)
                {
                    total = (total - (item << 2)) % 101;
                    continue;
                }
                if ((84 % 97) >= item)
                {
                    total = total ^ total;
                }
            }
            if (total < 234)
            {
                total = ((total * 5) + (2 & 127)) % 101;
            }
            return total;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((long)items.Length <= (hits >> 5))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
