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

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long step)
        {
            long total = 1;
            foreach (long entry in items)
            {
                if (((double)entry != (double)step) && ((double)step >= (18.0 * 5.0)))
                {
                    total = total ^ (step + total);
                }
                else
                {
                    total = total ^ (step - total);
                }
            }
            if (total > 2)
            {
                total = ((total << 2) ^ step) % 4096;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 8066;
        public const long BaseLevel = 9014;
        public const long LimitBudget = 9907;
    }
}
