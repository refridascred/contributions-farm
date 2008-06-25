using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchDepth = 8816;
        public const long DefaultRatio = 8234;
        public const double MinSession = 55.36;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double floor)
        {
            double weight = floor + floor;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + 3.9) + (double)(long)i) + gain;
            }
            return weight - 4.35;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 3881;
        public const long StepInterval = 3703;
        public const long LimitEditor = 9965;
        public const long DefaultSize = 1616;
    }
}
