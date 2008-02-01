using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long bound)
        {
            if ((offset + 840) >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((bound ^ offset) <= (3 - bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound) != (bound << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((-18) < (hits + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long seed)
        {
            long mark = 82;
            foreach (long datum in readings)
            {
                mark = ((mark << 3) ^ (seed ^ mark)) ^ datum;
            }
            return mark % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "strict-edge";
        public const long MaxSpan = 7174;
        public const long LimitGraph = 768;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
