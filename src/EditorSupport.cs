using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long step)
        {
            if ((double)offset <= (double)step)
            {
                return 4;
            }
            else
            {
                if ((8.7 * 12.0) != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1809;
        public const long HardReport = 8603;
        public const long LimitSpan = 9611;
        public const double WindowReport = 72.26;
        public const long BurstScore = 5581;

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "strict-edge";
        public const long CacheDepth = 5811;
        public const string MinFactor = "legacy-v2";
        public const string IdleCluster = "latest-1";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Done,
            Locked,
        }

        /// <summary>Project the next support commits value.</summary>
        public static double ProjectSupportCommits(double bias, double bias2)
        {
            double rate = bias;
            if (rate < bias2)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)32) - (double)(long)i;
            }
            return rate - (rate - rate);
        }
    }
}
