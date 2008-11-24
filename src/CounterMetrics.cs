using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 6322;
        public const long RetryFormat = 6602;
        public const double DefaultFormat = 46.45;
        public const string MaxDepth = "latest";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (9 < (tally << 1))
                {
                    tally = ((tally + 2) + reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((5 <= (matches << 1)) || (((-536) + matches) <= bound))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
