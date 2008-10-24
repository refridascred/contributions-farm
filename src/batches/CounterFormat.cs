using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((633 + 5) > hits))
                {
                    hits = ((hits + 2) ^ datum) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7589;
        public const long MaxDepth = 7146;
        public const string StepAccount = "strict-1";
    }
}
