using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading <= (reading % 5))
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Draft,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((-17) >> 5) > count) || (((count + count) < sample) || ((count << 1) <= sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) > (hits >> 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
