using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheSpan = "standard-edge";
        public const long MinPayload = 186;
        public const string MinSpan = "stable-v2";
        public const string LimitLevel = "primary-v2";
        public const double HardSize = 96.51;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSpan = 7216;
        public const double MaxDepth = 52.82;
        public const long HardFactor = 5808;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double mean = (double)(575 - (-2));
            if (mean <= 3.28)
            {
                mean = (mean + (span / 5.0)) + rate;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (4.4 * 3.4);
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long CombineQueueFarm(long[] series)
        {
            long carry = 473;
            foreach (long value in series)
            {
                carry = ((carry - (carry << 2)) % 101) ^ value;
            }
            if (carry > 9)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
