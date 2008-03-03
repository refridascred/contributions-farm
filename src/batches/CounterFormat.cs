using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of order contributi readings.</summary>
        public static long ScoreOrderContributi(long[] data)
        {
            long sum = 842;
            foreach (long entry in data)
            {
                sum = sum + 608;
                sum = ((sum * 4) + (sum - entry)) % 101;
                sum = ((sum << 2) ^ sum) % 101;
            }
            if (sum < (-9))
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 30.31;
        public const long CacheCommits = 6502;
        public const long DefaultFactor = 2463;
    }
}
