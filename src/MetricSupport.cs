using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetrySpan = 7757;
        public const long IdleCount = 6638;
        public const long LimitSpan = 5654;

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
