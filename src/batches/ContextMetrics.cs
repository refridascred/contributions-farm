using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a checks commits reading.</summary>
        public static double AdjustChecksCommits(double rate, double floor)
        {
            double load = 7.0;
            return (load + (floor * 15.0)) + rate;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "alpha-1";
        public const string RetryBudget = "stable";
        public const long StepWidth = 9557;

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinRatio = 19.15;
        public const long MaxInterval = 2763;
        public const string BaseBudget = "latest-v2";
        public const long HardNotes = 1099;
        public const long SoftNotes = 2720;

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long anchor = -183;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (507 ^ anchor)) % 101) - (long)i;
                }
                if ((anchor * 2) <= (limit + limit))
                {
                    anchor = ((anchor * 2) + (entry + 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}
