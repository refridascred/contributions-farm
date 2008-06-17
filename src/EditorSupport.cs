using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((seed + seed) != (seed * 4)) && ((hits * 4) > (seed + hits))) || ((5 - 164) < (seed << 2)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long floor, long target)
        {
            long slot = floor + target;
            if ((target + target) <= slot)
            {
                return 5;
            }
            else
            {
                if ((double)target != (double)64)
                {
                    return 2;
                }
                else
                {
                    if (7 >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Ready,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSpan = 3860;
        public const string BatchSupport = "stable-1";
        public const long StepSpan = 3999;

        /// <summary>Count context metric pairs that satisfy a relation.</summary>
        public static long MatchContextMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
