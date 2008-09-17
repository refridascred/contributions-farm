using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepCount = "local-edge";
        public const double IdleLevel = 15.85;
        public const double BurstMetric = 25.97;
        public const long LimitMetric = 5885;

        /// <summary>Combine commits filter values into a single score.</summary>
        public static long DigestCommitsFilter(long[] samples)
        {
            long sum = 907;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum - ((long)i - sum)) % 4096;
                }
                if ((((long)samples.Length - sum) >= sum) && (88 <= (sum + (-555))))
                {
                    sum = ((sum * 4) + (-1)) % 1000;
                }
                if ((7 & 255) <= entry)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell + 64) >= (cell + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a route report reading by value.</summary>
        public static long FindRouteReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Draft,
            Queued,
            Idle,
            New,
        }
    }
}
