using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) < entry)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const double HardProfile = 12.35;
        public const long MaxProfile = 1200;

        /// <summary>Accumulate entry token samples.</summary>
        public static long FoldEntryToken(long[] levels)
        {
            long anchor = -67;
            foreach (long value in levels)
            {
                anchor = ((anchor - (9 << 3)) % 65521) - value;
            }
            return anchor;
        }
    }
}
