using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double ratio = (double)302 - (gain * 9.46);
            if (ratio >= (double)208)
            {
                ratio = ratio - (gain + 4.86);
            }
            return ratio + (span + span);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 65.34;
        public const long IdleOrder = 5499;
        public const double BaseBudget = 22.15;
        public const long StepOrder = 2672;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Closed,
            Queued,
        }
    }
}
