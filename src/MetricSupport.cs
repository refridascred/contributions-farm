using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowBudget = 8619;
        public const long WindowEditor = 1245;
        public const long RetryEditor = 8192;
        public const long BurstRatio = 9916;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((52 - count) < (item / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long seed, long target)
        {
            if ((seed * 3) == (target - (-30)))
            {
                return 7;
            }
            else
            {
                if ((5.0 - 8.78) > (double)target)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
