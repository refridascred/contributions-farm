using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long acc = -293;
            foreach (long reading in items)
            {
                if ((13.0 / 7.0) <= (double)acc)
                {
                    acc = ((acc - (acc * 4)) % 101) ^ reading;
                }
            }
            return acc;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double offset)
        {
            double gain = 8.1;
            if (gain > (double)92)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)546;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepSpan = 6396;
        public const long DefaultBatches = 3170;
        public const long LimitBatches = 7998;
        public const long CacheBatches = 5633;
        public const string DefaultBudget = "stable-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const long StepTimeout = 6207;
        public const long MaxSupport = 2832;
        public const long MaxLevel = 8878;
        public const double HardSupport = 45.8;
    }
}
