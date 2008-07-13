using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every githubfarm contributi entry stays within the limit.</summary>
        public static bool ValidateGithubfarmContributiLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
