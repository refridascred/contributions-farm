using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double bias2 = (bias / 9.0) * 8.79;
            if (bias2 > (double)58)
            {
                bias2 = (bias2 + bias2) - span;
            }
            return bias2 + bias2;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 4) == (limit * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics token figure with a bias.</summary>
        public static double ProjectMetricsToken(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstInterval = 16.37;
        public const string SoftMetric = "alpha";
        public const double RetryBudget = 18.26;
        public const long WindowBudget = 4228;
    }
}
