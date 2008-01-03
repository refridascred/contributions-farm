using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double mean = 6.0;
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean - mean) - (double)(long)i) - ratio) + span;
            }
            return mean - (mean * 2.82);
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(floor < (long)levels.Length))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double mean = (double)(5 >> 5);
            if (mean >= mean)
            {
                mean = (mean + mean) - scale;
            }
            return mean + bias;
        }

        /// <summary>Count the stats report entries that pass the check.</summary>
        public static long TallyStatsReportGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((cell <= tally) || (tally > (long)data.Length)) && ((tally - tally) <= cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
