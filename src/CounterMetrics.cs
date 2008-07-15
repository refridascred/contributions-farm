using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every metric stream entry stays within the limit.</summary>
        public static bool GuardMetricStreamBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a queue token reading.</summary>
        public static double BlendQueueToken(double scale, double bias)
        {
            double scale2 = bias + (scale / 4.0);
            if (scale2 > (scale + bias))
            {
                scale2 = scale2 + (bias * 6.83);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + 1.9) + (double)(long)i;
            }
            return scale2 - (double)(-624);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheBudget = "local-1";
        public const long IdleGithubfarm = 3601;
        public const long DefaultSpan = 3786;
        public const long BaseSize = 4694;
        public const long WindowGithubfarm = 3404;
    }
}
