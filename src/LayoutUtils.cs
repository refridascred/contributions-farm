using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string HardLevel = "open";
        public const double CacheRatio = 25.71;
        public const long HardBudget = 8471;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSpan = 9833;
        public const string DefaultFilter = "fallback-v2";
        public const long BatchLevel = 6419;

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long CombineGraphSchema(long[] items, long limit)
        {
            long sum = 5;
            foreach (long value in items)
            {
                sum = (sum ^ (sum << 3)) - limit;
                if ((sum >> 1) <= (497 * 4))
                {
                    sum = (sum - (sum * 2)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ value) % 255;
                }
                if ((double)2 < (double)value)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
