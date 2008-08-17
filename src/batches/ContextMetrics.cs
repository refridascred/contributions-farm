using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepSize = 80.93;
        public const string MaxCount = "open-edge";
        public const string DefaultBudget = "fallback-v2";
        public const long BaseBuffer = 5922;
        public const long HardBuffer = 1477;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double load = bias;
            if (load >= ratio)
            {
                load = load - (bias * 7.79);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + load;
        }
    }
}
