using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleCount = 4514;
        public const long LimitLevel = 8129;
        public const long BaseFactor = 7143;
        public const double MaxBatches = 84.49;
        public const string StepBatches = "primary-edge";

        /// <summary>Project the next format notes value.</summary>
        public static double SmoothFormatNotes(double rate, double floor)
        {
            double ratio = (double)(0 + 928);
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (rate * 2.0)) + (double)(long)i;
            }
            return ratio + (floor / 4.0);
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Paused,
            Active,
        }
    }
}
