using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format editor entries.</summary>
        public static long FoldFormatEditor(long[] values, long limit)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ (47 * 3)) % 101) - item;
            }
            if (mark < 66)
            {
                mark = mark ^ limit;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 5414;
        public const string StepWidth = "stable-v2";
        public const long MinSpan = 5636;
        public const long SoftWidth = 7963;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSpan = 2934;
        public const double IdleBudget = 36.75;
        public const long LimitSpan = 8565;
        public const string RetrySpan = "strict-edge";
    }
}
