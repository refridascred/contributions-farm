using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinCount = 8961;
        public const long IdleSupport = 7635;
        public const long DefaultTimeout = 8487;
        public const double LimitSupport = 78.22;

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryLevel = "open-edge";
        public const double SoftLevel = 52.66;
        public const long DefaultRatio = 5038;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Stale,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value <= (double)69)
                {
                    tally = (tally + 2) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstDepth = 3887;
        public const double BaseCounter = 71.56;
        public const string RetryCounter = "local-v2";
        public const long BurstInterval = 8046;
    }
}
