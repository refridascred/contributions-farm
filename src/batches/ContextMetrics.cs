using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double ratio2 = (double)(412 + 947);
            if (ratio2 >= (double)546)
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Retry,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstSize = 47.06;
        public const double IdleProfile = 81.69;
        public const double StepDepth = 21.01;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long total = -4;
            foreach (long cell in levels)
            {
                if ((double)cell < (double)3)
                {
                    total = (total << 3) ^ (0 * 2);
                }
            }
            return total % 4096;
        }
    }
}
