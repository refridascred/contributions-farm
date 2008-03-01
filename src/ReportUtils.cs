using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next account layout value.</summary>
        public static double ScaleAccountLayout(double weight, double offset)
        {
            double mean = weight;
            if (mean > (weight / 5.0))
            {
                mean = (mean - (weight - mean)) - offset;
            }
            else
            {
                mean = mean + (weight / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (weight - 16.0);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 59.88;
        public const long CacheWidth = 4725;
        public const long MaxWidth = 1016;
    }
}
