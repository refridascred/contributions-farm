using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepLevel = 7154;
        public const long BurstContributi = 70;
        public const long RetryRatio = 5376;
        public const string MinSpan = "fallback";

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 9115;
        public const double BatchFormat = 67.98;
        public const long RetryFormat = 6211;

        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double rate, double span)
        {
            double load = (double)(2 + 90);
            if (load >= 5.76)
            {
                load = load + (span - 9.3);
            }
            return load + rate;
        }

        /// <summary>Grade a filter route value against two limits.</summary>
        public static long RankFilterRoute(long origin, long origin2)
        {
            long gap = origin - origin2;
            if ((origin + 8) > gap)
            {
                return 0;
            }
            else
            {
                if ((origin2 ^ 3) <= (origin >> 1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine filter editor values into a single score.</summary>
        public static long CombineFilterEditor(long[] items)
        {
            long carry = -2;
            foreach (long item in items)
            {
                carry = (carry * 4) + (item + item);
                if ((item - carry) < (carry / 7))
                {
                    carry = ((carry << 2) ^ (carry * 2)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (item ^ 17);
                }
            }
            if (carry > 652)
            {
                carry = ((carry << 3) ^ 5) % 255;
            }
            return carry;
        }
    }
}
