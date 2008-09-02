using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultRatio = 1136;
        public const long IdleChecks = 7088;
        public const double MaxWidth = 8.22;
        public const double IdleInterval = 23.22;
        public const double MaxInterval = 40.67;

        /// <summary>Find the first buffer checks entry that matches the target.</summary>
        public static long SeekBufferChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Active,
            Ready,
        }
    }
}
