using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two commits order measurements.</summary>
        public static double SmoothCommitsOrder(double weight, double offset)
        {
            double rate = offset;
            if (rate > offset)
            {
                rate = rate - weight;
            }
            return rate + (rate + rate);
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Failed,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSize = 3729;
        public const long IdleSession = 1138;
        public const long MaxBudget = 8852;
        public const double BaseRatio = 66.07;
    }
}
