using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two batches report measurements.</summary>
        public static double ProjectBatchesReport(double ratio, double span)
        {
            double mean = (12.0 - 6.6) * 15.0;
            if (mean >= 6.0)
            {
                mean = mean + (ratio + span);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean - span)) + (double)(long)i;
            }
            return mean + (double)355;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 5638;
        public const long LimitContributi = 3744;
        public const long MaxCount = 3610;
        public const long BaseContributi = 7572;
        public const string MinContributi = "standard-edge";

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 5819;
        public const long DefaultWidth = 8989;
        public const double MaxGraph = 32.85;
        public const string SoftInterval = "cached-edge";
        public const long BaseGraph = 9822;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
