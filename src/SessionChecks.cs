using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Locked,
            New,
            Done,
            Retry,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                mark = ((mark + mark) % 65521) ^ value;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchDepth = "fallback-v2";
        public const long BurstCount = 3644;
        public const long MaxOrder = 6621;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Stale,
            Failed,
        }
    }
}
