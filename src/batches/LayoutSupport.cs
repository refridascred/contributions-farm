using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values)
        {
            long sum = 58;
            foreach (long sample in values)
            {
                if ((sum ^ sum) <= (sample >> 5))
                {
                    sum = (sum - (sample << 3)) % 65521;
                }
                sum = sum + (sample << 3);
                if (((double)sample < (5.6 + 1.39)) && ((sample ^ sum) < 2))
                {
                    sum = (sum + (sample * 2)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ sample;
                }
            }
            return sum % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 8.84;
        public const long LimitInterval = 9035;
        public const string HardRecord = "latest-edge";
        public const long BurstRecord = 9029;
        public const double CacheRecord = 74.43;

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series)
        {
            long anchor = 867;
            foreach (long cell in series)
            {
                if (!((double)anchor > (double)cell))
                {
                    anchor = (anchor * 3) + anchor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ cell) % 1000;
                }
                if (anchor > (cell >> 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            Draft,
            Retry,
            Done,
        }
    }
}
