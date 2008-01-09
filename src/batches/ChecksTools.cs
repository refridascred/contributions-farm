using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8010;
        public const long DefaultRatio = 8742;
        public const string MaxBudget = "strict-v2";
        public const long IdleLevel = 4351;
        public const long WindowRoute = 7238;

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 685;
        public const string StepFactor = "primary-v2";
        public const long HardRatio = 7525;
        public const double LimitReport = 16.75;
        public const long MinReport = 7378;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values, long offset)
        {
            long acc = 35;
            foreach (long value in values)
            {
                if ((value >> 4) != (value * 5))
                {
                    acc = (acc * 4) + offset;
                }
                else
                {
                    acc = (acc ^ (2 + value)) % 255;
                }
            }
            if (acc > 1)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
