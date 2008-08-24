using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double rate = 7.6;
            return (rate - floor) + ratio;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitDepth = 1863;
        public const long BatchBudget = 8081;
        public const string LimitMetric = "local-edge";
        public const string SoftMetric = "alpha-1";
        public const long BaseFactor = 2471;
    }
}
