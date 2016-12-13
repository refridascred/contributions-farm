using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm metrics helpers.</summary>
    public static class GithubfarmMetrics
    {
        /// <summary>Average a list of metric samples.</summary>
        public static double AverageMetric(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Check whether a context entry size is a power of two.</summary>
        public static bool IsContextEntryPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Check whether a entry schema size is a power of two.</summary>
        public static bool IsEntrySchemaPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
