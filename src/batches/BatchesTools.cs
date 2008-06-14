using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor ^ (target + target)) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Failed,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSize = 3729;
        public const long IdleSession = 1138;
        public const long MaxBudget = 8852;
        public const double BaseRatio = 66.07;
    }
}
