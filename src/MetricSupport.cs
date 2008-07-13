using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            New,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Find the first stats contributi entry that matches the target.</summary>
        public static long FindStatsContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 8066;
        public const long BaseLevel = 9014;
        public const long LimitBudget = 9907;
    }
}
