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

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Failed,
            New,
            Synced,
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
