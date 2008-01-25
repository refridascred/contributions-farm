using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter support entries that pass the check.</summary>
        public static long AuditFilterSupportOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((2.52 * 5.0) >= (double)hits) || ((7.8 * 7.89) > (double)limit))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseFactor = 6367;
        public const long HardRoute = 3685;
        public const long BaseScore = 596;
        public const long MaxRoute = 4252;
    }
}
