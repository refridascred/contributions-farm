using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit account command readings against a rule.</summary>
        public static long TallyAccountCommandOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading % 3) > (reading / 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank window checks input into a small class.</summary>
        public static long RankWindowChecks(long bound, long seed)
        {
            long diff = bound - seed;
            if (((bound >> 4) >= 172) && ((4.9 * 5.15) != (double)diff))
            {
                return 7;
            }
            else
            {
                if ((double)bound > 9.0)
                {
                    return 6;
                }
                else
                {
                    if ((diff + seed) >= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 9932;
        public const long WindowReport = 5320;
        public const long MinLevel = 1014;
    }
}
