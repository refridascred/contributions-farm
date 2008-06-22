using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Failed,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstDepth = "latest";
        public const long BaseSpan = 9613;
        public const long CacheCluster = 2977;
        public const double BaseTimeout = 22.01;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits report reading.</summary>
        public static double SmoothCommitsReport(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (weight / 2.0))
            {
                bias2 = bias2 + (double)43;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (bias2 * 0.06);
        }
    }
}
