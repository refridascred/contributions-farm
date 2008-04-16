using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples, long bound)
        {
            long anchor = 539;
            foreach (long datum in samples)
            {
                if (datum <= 627)
                {
                    anchor = anchor - (anchor + 9);
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor + (bound / 4)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchLevel = 9755;
        public const double WindowLevel = 68.52;
        public const long BaseBatches = 7497;
        public const long IdleCount = 2043;
        public const long DefaultBudget = 776;

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "latest-edge";
        public const double BaseDepth = 50.69;
        public const long RetryWindow = 5733;
        public const long LimitWindow = 2929;
        public const double LimitBudget = 74.98;
    }
}
