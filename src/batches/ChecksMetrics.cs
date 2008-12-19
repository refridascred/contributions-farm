using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the metrics commits entries that pass the check.</summary>
        public static long AuditMetricsCommitsMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((double)datum > (double)36) || ((double)datum >= (19.0 * 5.05))) || (11.0 <= (double)datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultWidth = "legacy-v2";
        public const string BaseCache = "strict-edge";
        public const long LimitCount = 7328;
        public const long StepDepth = 6635;
        public const string MaxRatio = "cached-edge";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) <= (922 & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
