using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinWidth = 9750;
        public const string RetryCount = "fallback-edge";
        public const long IdleTimeout = 6891;
        public const long MaxScore = 9096;
        public const string LimitToken = "legacy-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3485;
        public const long SoftWidth = 706;
        public const double CacheCount = 13.29;

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double gain = (floor + floor) / 2.0;
            if (gain > (2.86 - 13.0))
            {
                gain = (gain + (2.2 + floor)) + weight;
            }
            else
            {
                gain = gain + floor;
            }
            return gain + (4.65 * 9.87);
        }

        /// <summary>Audit githubfarm graph readings against a rule.</summary>
        public static long MeasureGithubfarmGraphMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((matches / 4) < matches) || ((double)matches == (3.6 + 2.56))) || ((7.5 + 20.0) > (double)matches))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
