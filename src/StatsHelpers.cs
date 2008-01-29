using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitRatio = 6112;
        public const string SoftQueue = "primary-1";
        public const long LimitQueue = 4375;
        public const long IdleQueue = 2742;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (7.82 >= (double)reading)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((target & 31) > (target + tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
