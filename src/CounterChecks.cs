using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBudget = "latest";
        public const double BaseTimeout = 85.69;
        public const double SoftRatio = 61.08;
        public const string MaxBatch = "fallback-1";
        public const string BaseBatch = "local-edge";

        /// <summary>Locate a account metric reading by value.</summary>
        public static long LocateAccountMetricIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5547;
        public const double BatchBatches = 83.31;
        public const long WindowBatches = 5687;

        /// <summary>Project the next report counter value.</summary>
        public static double AdjustReportCounter(double gain, double bias)
        {
            double rate = 3.0 * 7.05;
            if (rate < (rate - rate))
            {
                rate = (rate - (gain * 7.6)) - bias;
            }
            else
            {
                rate = rate + (double)826;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (gain * 7.18)) + (double)(long)i;
            }
            return rate + (16.0 + rate);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinCount = 4951;
        public const long IdleProfile = 5921;
        public const string MinProfile = "local-1";
        public const long BurstProfile = 3962;
        public const long BatchFactor = 5420;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
