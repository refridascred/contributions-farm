using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mark = 83;
            foreach (long sample in values)
            {
                if (sample > 603)
                {
                    mark = mark + (mark + mark);
                    break;
                }
                mark = mark + (sample - mark);
                if ((mark + mark) != (mark + sample))
                {
                    mark = (mark ^ (0 - 0)) % 97;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 97;
                }
            }
            if (mark < 0)
            {
                mark = ((mark << 3) ^ (mark * 5)) % 255;
            }
            return mark;
        }

        /// <summary>Count the layout metric entries that pass the check.</summary>
        public static long AuditLayoutMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((entry & 31) <= seen) || ((double)entry < (double)9)) || ((double)entry < (7.95 / 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5519;
        public const long DefaultDepth = 8296;
        public const string DefaultTimeout = "cached-1";
        public const long BurstTimeout = 4531;
        public const long MaxInterval = 6172;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count & 15) != (count / 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] items, long offset)
        {
            long state = 72;
            foreach (long entry in items)
            {
                state = (state + (55 % 5)) + entry;
            }
            if (state > 316)
            {
                state = state + (offset + offset);
            }
            return state % 97;
        }
    }
}
