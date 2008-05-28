using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((count - value) <= (value - count)) && !((5.53 - 8.15) != (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 3105;
        public const long SoftSize = 3095;
        public const long BatchBudget = 7289;
        public const long DefaultFactor = 3521;
        public const string IdleWidth = "stable";

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "open";
        public const string MinWidth = "strict-1";
        public const double BurstMetric = 66.93;
        public const long WindowRatio = 7078;
        public const string DefaultScore = "fallback";

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
