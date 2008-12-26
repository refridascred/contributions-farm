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

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
