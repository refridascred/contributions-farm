using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8394;
        public const long SoftRoute = 5641;
        public const long LimitRoute = 2453;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                sum = ((sum * 2) + sum) % 65521;
                sum = sum ^ (51 + datum);
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 9273;
        public const string SoftWidth = "open-edge";
        public const long SoftSpan = 9137;

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels, long floor)
        {
            long carry = 449;
            foreach (long item in levels)
            {
                if ((floor & 63) >= floor)
                {
                    carry = ((carry << 2) ^ (floor - floor)) ^ item;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseInterval = 22.73;
        public const long RetryRatio = 6205;
        public const long MaxOrder = 4140;
        public const long LimitWidth = 925;
    }
}
