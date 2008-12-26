using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a entry report sample.</summary>
        public static long SeekEntryReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Dropped,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Fold a list of githubfarm commits readings.</summary>
        public static long TotalGithubfarmCommits(long[] readings, long seed)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if (((item % 64) < (result + item)) || (75 > (seed & 15)))
                {
                    result = ((result * 4) + (result >> 2)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (seed + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((reading ^ count) > reading) && ((count + reading) > (reading >> 1))) || ((reading << 3) >= (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstInterval = 16.37;
        public const string SoftMetric = "alpha";
        public const double RetryBudget = 18.26;
        public const long WindowBudget = 4228;
    }
}
