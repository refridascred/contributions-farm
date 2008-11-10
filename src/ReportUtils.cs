using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double scale = ratio;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale + (double)76;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchScore = "legacy-edge";
        public const double IdleSize = 56.75;
        public const long BaseDepth = 8256;
        public const long CacheLevel = 3708;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchFactor = "alpha";
        public const long CacheRatio = 2167;
        public const long HardBudget = 7588;
        public const long MaxWidth = 9967;
        public const string LimitSupport = "fallback-v2";
    }
}
