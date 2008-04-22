using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a contributi stream reading.</summary>
        public static double ScaleContributiStream(double scale, double floor)
        {
            double mean = (double)(607 * 5);
            if (mean <= (scale / 3.0))
            {
                mean = mean - (8.2 + scale);
            }
            return mean - (mean + floor);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowBudget = 2015;
        public const long RetryLevel = 8551;
        public const string MaxBudget = "primary";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheSpan = 6786;
        public const long SoftMetrics = 394;
        public const long SoftRatio = 6991;
        public const long BatchMetrics = 285;
        public const string MaxWidth = "staging-v2";
    }
}
