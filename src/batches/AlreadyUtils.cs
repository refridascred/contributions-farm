using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 624;
        public const long BatchMetrics = 993;
        public const long BaseBudget = 8432;
        public const long StepBudget = 8844;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Weight { get; set; }
            public double Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double bias2 = bias / 5.0;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - (double)6) - (double)(long)i) + scale;
            }
            return bias2 + (double)7;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Closed,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryRatio = 939;
        public const long HardAlready = 5850;
        public const long RetryAlready = 7262;
    }
}
