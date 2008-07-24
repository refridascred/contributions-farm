using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Locked,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "legacy-edge";
        public const string StepSpan = "latest-edge";
        public const double HardCounter = 41.92;
        public const long RetryCounter = 6127;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double weight2 = (double)75;
            return ((weight2 + (weight2 * 0.4)) + weight) + offset;
        }
    }
}
