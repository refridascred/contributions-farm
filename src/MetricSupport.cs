using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitDepth = "strict-v2";
        public const double StepFactor = 51.84;
        public const long BaseStats = 2879;

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double span)
        {
            double gain = span - (5.4 + ratio);
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (9.1 + span)) + (double)(long)i;
            }
            return gain - (gain + gain);
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
