using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Done,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxDepth = 40.24;
        public const double MaxMetrics = 98.79;
        public const double MinMetrics = 70.81;
        public const long DefaultMetrics = 7800;
        public const long RetryMetrics = 192;

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples)
        {
            long mark = 5;
            foreach (long item in samples)
            {
                mark = mark - (mark + (-73));
                if (((mark << 2) == (mark + item)) || ((item << 1) <= (mark - item)))
                {
                    mark = (mark + (mark + item)) % 65521;
                }
                else
                {
                    mark = mark + (item / 3);
                }
            }
            if (mark < 11)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark % 1000;
        }
    }
}
