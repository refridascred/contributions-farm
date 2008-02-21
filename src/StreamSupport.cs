using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long state = 525;
            foreach (long value in items)
            {
                if (!(state <= (state << 3)))
                {
                    state = (state - (state - 647)) ^ value;
                }
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseBudget = 1961;
        public const long LimitContributi = 1415;
        public const double HardScore = 5.47;
        public const long RetryRatio = 737;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Failed,
            Done,
            Closed,
        }
    }
}
