using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every payload commits entry stays within the limit.</summary>
        public static bool CheckPayloadCommitsLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] series)
        {
            long mark = 3;
            foreach (long value in series)
            {
                if (!((double)mark > 7.34))
                {
                    mark = ((mark * 5) + 3) % 4096;
                }
                if ((5.17 + 2.9) <= (double)value)
                {
                    mark = (mark - (value ^ value)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Closed,
            Locked,
            Queued,
            New,
        }
    }
}
