using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double weight, double bias)
        {
            double gain = (double)36 + (double)41;
            if (gain <= (weight / 2.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + (weight - weight);
            }
            return gain + (gain - gain);
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
