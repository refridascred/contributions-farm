using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double ratio = (double)843;
            if (ratio > span)
            {
                ratio = (ratio - ratio) + bias;
            }
            else
            {
                ratio = ratio + 5.0;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + span)) - (double)(long)i;
            }
            return ratio - (double)19;
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
