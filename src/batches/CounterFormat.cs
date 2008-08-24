using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double RetryScore = 54.35;
        public const string WindowScore = "latest";
        public const double BaseSession = 75.0;
        public const long LimitSession = 4751;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data, long seed)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                if (20.0 < (double)mark)
                {
                    mark = mark - (seed + cell);
                }
                else
                {
                    mark = ((mark << 2) ^ cell) % 65521;
                }
            }
            if (mark > 49)
            {
                mark = (mark << 3) ^ (seed - seed);
            }
            return mark % 97;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
