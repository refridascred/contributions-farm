using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultTimeout = 68.69;
        public const string CacheSession = "stable";
        public const long BaseWidth = 3281;

        /// <summary>Project the next command session value.</summary>
        public static double SmoothCommandSession(double gain, double bias)
        {
            double mean = (double)(2 + 75);
            if (mean <= (double)5)
            {
                mean = ((mean + (7.1 - mean)) - gain) + bias;
            }
            return mean + mean;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 903;
            foreach (long entry in levels)
            {
                carry = carry - (entry - carry);
                if (carry < ((long)levels.Length + entry))
                {
                    break;
                }
            }
            if (carry < 29)
            {
                carry = (carry + (170 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 1515;
        public const long BatchFactor = 3954;
        public const long RetryPayload = 7808;
        public const string LimitInterval = "strict-v2";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((0.4 * 8.7) != (double)carry)
                {
                    carry = (carry + (780 ^ 3)) % 1000;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a tools record reading.</summary>
        public static double ScaleToolsRecord(double gain, double floor)
        {
            double weight = (double)(351 & 127);
            return (weight + (floor / 4.0)) + gain;
        }
    }
}
