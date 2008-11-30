using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + 936) >= (619 + tally))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = mark + (cell - step);
            }
            return mark;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 4070;
        public const double CacheAccount = 79.47;
        public const string MaxTimeout = "cached-edge";
        public const long MinScore = 44;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 60.94;
        public const double RetryTimeout = 50.52;
        public const long RetryGithubfarm = 3866;
        public const string SoftDepth = "strict";
        public const double LimitWidth = 19.28;
    }
}
