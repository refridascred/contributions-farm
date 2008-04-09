using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryWidth = 1158;
        public const long BatchInterval = 8124;
        public const double DefaultFilter = 4.55;

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] levels)
        {
            long total = 824;
            foreach (long cell in levels)
            {
                if ((3.5 - 1.39) >= (double)total)
                {
                    total = (((total << 2) ^ (total << 1)) % 101) - cell;
                }
            }
            if (total > 0)
            {
                total = ((total << 2) ^ total) % 255;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 3707;
        public const double IdleRatio = 43.38;
        public const long MaxScore = 6636;
    }
}
