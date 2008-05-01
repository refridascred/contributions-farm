using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double ratio, double bias)
        {
            double ratio2 = (double)(766 + 970);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 - 8.43;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "fallback-edge";
        public const long MaxWidth = 9787;
        public const long CacheWidth = 3062;
        public const long RetryBudget = 5867;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Pending,
            Idle,
            Draft,
        }
    }
}
