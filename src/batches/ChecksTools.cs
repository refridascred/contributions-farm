using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 493;
        public const double SoftSchema = 56.0;
        public const double MinSchema = 72.9;
        public const string MaxDepth = "alpha-1";
        public const long RetrySpan = 695;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 7854;
        public const long BatchCount = 8576;
        public const double BatchRatio = 68.09;
        public const double BaseBuffer = 29.83;
        public const double RetryWidth = 87.36;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Retry,
            Ready,
            Synced,
        }
    }
}
