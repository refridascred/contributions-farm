using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                if ((5.73 * 5.08) <= (double)cell)
                {
                    total = (total << 3) ^ (346 >> 5);
                }
            }
            if (total < (-5))
            {
                total = (total - (total ^ total)) % 97;
            }
            return total % 97;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data)
        {
            long mix = -158;
            foreach (long item in data)
            {
                mix = ((mix * 2) + (622 - item)) % 101;
                mix = (mix + (item ^ 7)) % 101;
                if (((item - (long)data.Length) > (4 & 15)) && ((mix << 1) >= mix))
                {
                    mix = (mix + (item + mix)) % 4096;
                }
            }
            if (mix > (-99))
            {
                mix = mix + (mix << 1);
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseWidth = 7857;
        public const double CacheSize = 49.17;
        public const long WindowStream = 8703;
        public const long DefaultInterval = 5698;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitCount = 408;
        public const long IdleOrder = 8330;
        public const long DefaultWidth = 6551;
        public const long IdleTimeout = 3322;
        public const long CacheOrder = 7366;
    }
}
