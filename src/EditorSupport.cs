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

        /// <summary>Measure how many githubfarm report samples are out of range.</summary>
        public static long AuditGithubfarmReportHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((0 - count) > (count + 83))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
