using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinTimeout = 3132;
        public const double CacheTimeout = 65.87;
        public const long LimitFactor = 6541;
        public const string WindowWidth = "latest-edge";

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
