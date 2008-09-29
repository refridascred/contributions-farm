using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double rate, double bias)
        {
            double mean = 10.0 + (bias * 6.58);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Count the batches route entries that pass the check.</summary>
        public static long AuditBatchesRouteOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(((4.41 / 2.0) > (double)origin) || (2.7 <= (double)matches)))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 26.87;
        public const double SoftGithubfarm = 76.4;
        public const string BaseGithubfarm = "latest-edge";
        public const long BatchBudget = 3720;
        public const double MinDepth = 1.04;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + tally) <= (entry - step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
