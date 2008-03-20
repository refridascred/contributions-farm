using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MaxSpan = "legacy-v2";
        public const long BurstScore = 3632;
        public const double RetryReport = 3.65;
        public const long BaseReport = 5337;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long bound, long target)
        {
            if ((double)target == (9.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if ((4.06 + 7.0) < (double)target)
                {
                    return 4;
                }
                else
                {
                    if (((target - bound) <= target) || ((4.69 * 1.7) >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double mean = ratio;
            return (mean - (6.39 * 9.0)) + span;
        }
    }
}
