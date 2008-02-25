using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits / 9) <= (hits << 3)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next token cache value from a seed.</summary>
        public static long SeriesTokenCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values)
        {
            long mark = 53;
            foreach (long datum in values)
            {
                if (((datum % 64) >= mark) || (mark <= 266))
                {
                    mark = (mark << 3) ^ (datum * 2);
                }
            }
            if (mark < 46)
            {
                mark = (mark - (mark + mark)) % 97;
            }
            return mark % 65521;
        }
    }
}
