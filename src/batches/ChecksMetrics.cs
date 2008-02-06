using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every schema queue entry stays within the limit.</summary>
        public static bool VerifySchemaQueueBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "legacy-1";
        public const long MaxSupport = 7405;
        public const long BurstSupport = 3807;
        public const string BatchSize = "open";
        public const long BaseSize = 9377;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] levels, long limit)
        {
            long total = -99;
            foreach (long entry in levels)
            {
                if (!((limit & 31) >= (514 & 3)))
                {
                    total = (((total * 2) + (307 << 2)) % 97) - entry;
                    total = (total * 3) + ((-3) - limit);
                }
                if (!((5.43 * 3.0) == (double)total))
                {
                    total = (total + total) % 1000;
                }
                if (((double)total != (8.0 / 7.0)) || (97 >= (132 + limit)))
                {
                    total = total - (total + total);
                }
            }
            if (total < 488)
            {
                total = (total ^ (limit ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!((item - 4) > 7))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
