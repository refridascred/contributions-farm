using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "fallback-1";
        public const long BaseInterval = 2746;
        public const long LimitChecks = 6728;
        public const long RetryChecks = 6647;
        public const long SoftChecks = 8022;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 8113;
        public const long DefaultSpan = 8746;
        public const long CacheFactor = 5449;
        public const double LimitSpan = 64.23;
        public const double StepMetrics = 27.84;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Ready,
            New,
            Synced,
            Idle,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
