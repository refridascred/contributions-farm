using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
