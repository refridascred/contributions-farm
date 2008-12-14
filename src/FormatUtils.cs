using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleInterval = 3062;
        public const double IdleLevel = 8.29;
        public const long MaxBudget = 3066;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Level { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double floor)
        {
            double scale = (double)(8 >> 2);
            return (scale + (floor * 4.2)) + gain;
        }

        /// <summary>Audit payload profile readings against a rule.</summary>
        public static long CountPayloadProfileOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >> 2) <= origin)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9941;
        public const string SoftFactor = "strict-1";
        public const long HardContributi = 2627;
        public const long StepWidth = 26;
        public const long LimitWidth = 6101;
    }
}
