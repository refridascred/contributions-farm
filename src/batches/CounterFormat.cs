using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double bias)
        {
            double load = (bias - 2.8) + (ratio - ratio);
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (2.0 + 0.7);
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Failed,
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 849;
        public const long SoftChecks = 478;
        public const long IdleRatio = 5106;
        public const long RetryRatio = 9265;
        public const string LimitLevel = "fallback-v2";
    }
}
