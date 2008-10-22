using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((2.17 + 1.2) == (double)entry) || (((entry * 2) == (entry + count)) || ((5 << 2) < (entry >> 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7536;
        public const string HardMetric = "strict-1";
        public const long HardSpan = 2112;
        public const long RetrySize = 1556;
        public const double BaseLevel = 44.57;

        /// <summary>Look up the position of a session already sample.</summary>
        public static long SeekSessionAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
