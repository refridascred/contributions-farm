using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long floor)
        {
            long mark = 54;
            foreach (long entry in values)
            {
                mark = ((mark << 3) ^ (floor & 15)) ^ entry;
            }
            if (mark > 284)
            {
                mark = (mark ^ (592 << 2)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Failed,
            New,
            Retry,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "cached-edge";
        public const string SoftBatch = "primary-1";
        public const string MinBudget = "stable";
    }
}
